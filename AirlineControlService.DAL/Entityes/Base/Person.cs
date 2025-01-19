namespace AirlineControlService.DAL.Entityes.Base
{
    public abstract class Person : NamedEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}