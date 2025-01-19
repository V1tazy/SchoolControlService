using AirlineControlService.DAL.Entityes.Base;

namespace AirlineControlService.DAL.Entityes
{
    public class Class : NamedEntity
    {
        public User Teacher { get; set; } // Вместо TeacherId указываем сущность User
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Связь с детьми
        public ICollection<ClassChild> ClassChildren { get; set; }
    }

}
