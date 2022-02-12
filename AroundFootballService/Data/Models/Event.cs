using AroundFootballService.Data.Enums;

namespace AroundFootballService.Data.Models
{
    public class Event
    {
        public int Id { get; set; }

        public int Minute { get; set; }

        public EventType EventType { get; set; }

        public bool IsDoneByHomeTeam { get; set; }

        public string? AdditionInformation { get; set; }

        public virtual Game Game { get; set; }
    }
}
