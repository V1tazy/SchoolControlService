using AirlineControlService.DAL.Entityes.Base;

namespace AirlineControlService.DAL.Entityes
{
    // Посещение
    public class Attendance : Entity
    {
        public Child Child { get; set; }
        public int ChildId { get; set; }

        public DateTime Date { get; set; }
        public string Description { get; set; }

        public User CreatedBy { get; set; } // Кто создал запись
        public int CreatedById { get; set; }
    }

}
