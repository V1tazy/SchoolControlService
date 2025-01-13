using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Models
{
    internal class Shedules
    {
        public int ID { get; set; }

        public User Teacher { get; set; }

        public string Date { get; set; }

        public string Start_Time { get; set; }

        public string End_Time { get; set; }

        public string Description { get; set; }
    }
}
