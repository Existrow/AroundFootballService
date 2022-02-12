using AroundFootballService.Data.Enums;

namespace AroundFootballService.Data.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Position Postiton { get; set; }

        public virtual Team Team { get; set; }

        public virtual List<StartingGrid> StartingGrids { get; set; }
    }
}
