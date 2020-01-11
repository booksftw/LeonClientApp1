using LeonClientApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeonClientApp.Utilities
{
    public class GeneralUtil : IGeneralUtil
    {

        public Rank getClientRank(int clientTotalSpending)
        {
            // logic to return rank
            Rank result;

            if (clientTotalSpending >= 0 && clientTotalSpending < 101)
            {
                // Normal 0 - 100
                result = Rank.Normal;
            }
            else if (clientTotalSpending >= 101 && clientTotalSpending < 1001)
            {
                // Good 101 - 1000
                result = Rank.Good;
            }
            else
            {
                // VIP 1001+
                result = Rank.VIP;
            }
            return result;
        }

        public string getHumanReadableRank(Rank rank)
        {
            switch (rank)
            {
                case Rank.Normal:
                    return "Normal Spender";
                case Rank.Good:
                    return "Good Spender";
                case Rank.VIP:
                    return "VIP Spender";
            }

            throw new Exception("There has been a problem determing the human readable rank in general utilities file");
        }
    }
}
