using AirlineControlService.DAL.Entityes.Base;

namespace AirlineControlService.DAL.Entityes
{
    public class ClassChild : Entity
    {
        public Class Class { get; set; } // Сущность Class
        public Child Child { get; set; } // Сущность Child
    }

}
