using AirlineControlService.DAL.Entityes.Base;

namespace AirlineControlService.DAL.Entityes
{
    // Промежуточная таблица для связи "многие-ко-многим" между родителями и детьми
    public class ParentChild : Entity
    {
        public User Parent { get; set; }
        public int ParentId { get; set; }

        public Child Child { get; set; }
        public int ChildId { get; set; }
    }

}
