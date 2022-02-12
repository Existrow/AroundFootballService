namespace AroundFootballService.Data.Models
{
    public class Tournament
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual List<Participant> Participants { get; set; }
    }
}
