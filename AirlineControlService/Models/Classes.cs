using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Models
{
    internal class Classes
    {
        public int ID { get; set; }

        public User teacher { get; set; }

        public string created_by { get; set; }

        public string updated_by { get; set; }
    }
}
