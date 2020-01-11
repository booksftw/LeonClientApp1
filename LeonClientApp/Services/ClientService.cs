using LeonClientApp.ApiModels;
using LeonClientApp.Database;
using LeonClientApp.Models;
using LeonClientApp.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeonClientApp.Services
{
    public class ClientService : IClientService 
    {
        private PrimaryDatabaseContext _db;
        private IGeneralUtil _util;

        public ClientService(PrimaryDatabaseContext primaryDatabaseContext, [FromServices] IGeneralUtil util)
        {
            _db = primaryDatabaseContext;
            _util = util;
        }

        public void Add(ClientDetailsDto clientData)
        {
            // Todo Validation

            var result = new Client();

            result.first_name = clientData.firstName;
            result.last_name = clientData.lastName;
            result.spending = clientData.totalSpending;
            result.birthday = clientData.birthday;
            result.rank = _util.getClientRank(clientData.totalSpending);
            result.date_created = DateTime.UtcNow;
            result.notes = clientData.notes;
            //Todo result.notes = decide logic here. 

            _db.Add(result);
            _db.SaveChanges();
        }

        public Client[] GetAll()
        {
            return _db.Client.ToArray();
        }

        public void DeleteClient(int id)
        {
            _db.Client.Remove(_db.Client.First(el => el.Id == id));
            _db.SaveChanges();
        }

    }
}
