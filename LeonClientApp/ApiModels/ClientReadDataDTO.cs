using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeonClientApp.ApiModels
{
    public class ClientReadDataDTO
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string birthday { get; set; }
        public int spending { get; set; }

        public string humanReadableRank { get; set; }
        public string notes { get; set; }
    }

    //id: number;
    //first_name: string;
    //last_name: string;
    //birthday: string;
    //spending: number;
    //status: string;
    //rank: number;
    //notes: string
}
