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

        // Навигационные свойства
        public ICollection<ParentChild> ParentChildren { get; set; } 
        public ICollection<Class> Classes { get; set; } 
        public ICollection<Schedule> Schedules { get; set; }
    }

}
