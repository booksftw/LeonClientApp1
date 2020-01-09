using LeonCustomerTracker.ApiModels;

namespace LeonClientApp.Services
{
    public interface IClientService
    {
        void Add(ClientDetailsDto clientData);
    }
}