using AirlineControlService.DAL.Entityes.Base;

namespace AirlineControlService.DAL.Entityes
{
    // Промежуточная таблица для связи "многие-ко-многим" между классами и детьми
    public class ClassChild : Entity
    {
        public Class Class { get; set; }
        public int ClassId { get; set; }

        public Child Child { get; set; }
        public int ChildId { get; set; }
    }

}
