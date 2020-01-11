using LeonClientApp.Models;

namespace LeonClientApp.Utilities
{
    public interface IGeneralUtil
    {
        Rank getClientRank(int clientTotalSpending);
        string getHumanReadableRank(Rank rank);
    }
}