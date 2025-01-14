using AirlineControlService.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Models.ChildrenJournal
{
    internal class Shedules: IEntity
    {
        public int Id { get; set; }

        public User Teacher { get; set; }

        public string Date { get; set; }

        public string Start_Time { get; set; }

        public string End_Time { get; set; }

        public string Description { get; set; }
    }
}
