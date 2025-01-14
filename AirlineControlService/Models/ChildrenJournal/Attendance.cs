using AirlineControlService.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Models.ChildrenJournal
{
    internal class Attendance: IEntity
    {
        public int Id { get; set; }

        public string Date { get; set; }

        public string Description { get; set; }

        public string Created_by { get; set; }
    }
}
