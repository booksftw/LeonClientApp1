using LeonClientApp.ApiModels;
using LeonClientApp.Database;
using LeonClientApp.Models;

namespace LeonClientApp.Services
{
    public interface IClientService
    {
        void Add(ClientDetailsDto clientData);
        Client[] GetAll();
        void DeleteClient(int id);
    }
}