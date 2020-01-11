using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeonClientApp.ApiModels;
using LeonClientApp.Services;
using LeonClientApp.Models;
using Microsoft.AspNetCore.Mvc;
using LeonClientApp.Utilities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LeonClientApp.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        // GET: api/<controller>
        [HttpGet("[action]")]
        public List<ClientReadDataDTO> GetAllClients( [FromServices] IClientService clientService, [FromServices] IGeneralUtil utilService)
        {
            var result = new List<ClientReadDataDTO>();
            var clients = clientService.GetAll().ToList();

            foreach (var client in clients)
            {
                var n = new ClientReadDataDTO() {
                    id = client.Id,
                    first_name = client.first_name,
                    last_name = client.last_name,
                    birthday = client.birthday.ToShortDateString(),
                    spending = client.spending,
                    humanReadableRank = utilService.getHumanReadableRank(client.rank),
                    notes = client.notes
                };

                result.Add(n);
            }

            return result;        
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost("[action]")]
        public void AddClient([FromBody] ClientDetailsDto clientData, [FromServices] IClientService clientService)

        {
            // Todo Validation
            clientService.Add(clientData);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void DeleteClient(int id, [FromServices] IClientService clientService)
        {
            Console.WriteLine(id);
            clientService.DeleteClient(id);
        }
    }
}
