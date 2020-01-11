using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeonClientApp.Models;

namespace LeonClientApp.ApiModels
{
    public class ClientNextMonthBirthdayDto
    {

        public string first_name { get; set; }

        public string last_name { get; set; }
        //[Required]
        public string birthday { get; set; }
        public int spending { get; set; }
        public string rank { get; set; }

    }
}
