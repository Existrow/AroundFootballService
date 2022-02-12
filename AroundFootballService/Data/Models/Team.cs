namespace AroundFootballService.Data.Models
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountryCode { get; set; }

        public string FlagUrl { get; set; }

        public virtual Region Region { get; set; }

        public virtual List<Participant> Participants { get; set; }

        public virtual List<Player> Players { get; set; }
    }
}
