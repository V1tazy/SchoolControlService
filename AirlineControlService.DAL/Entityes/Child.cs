using AirlineControlService.DAL.Entityes.Base;

namespace AirlineControlService.DAL.Entityes
{
    // Ребёнок
    public class Child : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Навигационные свойства
        public ICollection<ParentChild> ParentChildren { get; set; } // Связь с родителями
        public ICollection<ClassChild> ClassChildren { get; set; } // Связь с классами
    }

}
