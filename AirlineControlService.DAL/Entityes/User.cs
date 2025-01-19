using AirlineControlService.DAL.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.DAL.Entityes
{
    public class User : Person
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICollection<Class> Classes { get; set; } // У учителя есть список классов
        public ICollection<Schedule> Schedules { get; set; } // У учителя есть расписание
        public ICollection<Child> Children { get; set; }
    }

}
