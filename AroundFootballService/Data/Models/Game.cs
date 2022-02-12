using AroundFootballService.Data.Enums;

namespace AroundFootballService.Data.Models
{
    public class Game
    {
        public int Id { get; set; }

        public int HomeTeamResult { get; set; }

        public int AwayTeamResult { get; set; }

        public bool IsStarted { get; set; }

        public Stage Stage { get; set; }

        public virtual Participant ParticipantHome { get; set; }

        public virtual Participant ParticipantAway { get; set; }

        public virtual List<Event> Events { get; set; }

        public virtual List<StartingGrid> StartingGrids { get; set; }
    }
}
