using AirlineControlService.DAL.Entityes.Base;

namespace AirlineControlService.DAL.Entityes
{
    // Класс
    public class Class : NamedEntity
    {
        public User Teacher { get; set; } // Учитель, связанный с классом
        public int TeacherId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Навигационные свойства
        public ICollection<ClassChild> ClassChildren { get; set; } // Дети в классе
    }

}
