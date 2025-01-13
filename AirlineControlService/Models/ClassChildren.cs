using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Models
{
    internal class ClassChildren
    {
        public int ID { get; set; }
        public Classes Class { get; set; }
        public Children Child {  get; set; }
    }
}
