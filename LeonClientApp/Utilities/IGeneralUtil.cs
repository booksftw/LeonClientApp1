using LeonCustomerTracker.Models;

namespace LeonCustomerTracker.Utilities
{
    public interface IGeneralUtil
    {
        Rank getClientRank(int clientTotalSpending);
    }
}