using AroundFootballService.Data.Enums;

namespace AroundFootballService.Data.Models
{
    public class Participant
    {
        public int Id { get; set; }

        public Group Group { get; set; }

        public virtual Team Team { get; set; }

        public virtual Tournament Tournament { get; set; }

        public virtual List<Game> HomeGames { get; set; }

        public virtual List<Game> AwayGames { get; set; }
    }
}
