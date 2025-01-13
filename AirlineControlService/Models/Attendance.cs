using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Models
{
    internal class Attendance
    {
        public int ID { get; set; }

        public string Date { get; set; }

        public string Description { get; set; }

        public string Created_by {  get; set; }
    }
}
