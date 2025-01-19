using AirlineControlService.DAL.Entityes.Base;

namespace AirlineControlService.DAL.Entityes
{
    // Расписание
    public class Schedule : Entity
    {
        public User Teacher { get; set; }
        public int TeacherId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Description { get; set; }
    }

}
