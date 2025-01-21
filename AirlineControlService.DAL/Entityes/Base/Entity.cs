

using AirlineControlService.Interfaces;

namespace AirlineControlService.DAL.Entityes.Base
{
    public abstract class Entity: IEntity
    {
        public int Id { get; set; }
    }

}