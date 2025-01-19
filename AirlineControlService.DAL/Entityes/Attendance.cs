using AirlineControlService.DAL.Entityes.Base;

namespace AirlineControlService.DAL.Entityes
{
    public class Attendance : Entity
    {
        public Child Child { get; set; } // Сущность Child вместо ChildId
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public User CreatedBy { get; set; } // Сущность User вместо CreatedById
    }

}
