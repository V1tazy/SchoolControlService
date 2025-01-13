using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Models
{
    internal class Children
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Birth_day { get; set; }

        public User Parent { get; set; }

        public string Created_at { get; set; }

        public string Update_at { get; set; }
    }
}
