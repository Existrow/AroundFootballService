using AroundFootballService.Data.Enums;

namespace AroundFootballService.Data.Models
{
    public class StartingGrid
    {
        public int Id { get; set; }

        public bool IsHomeTeam { get; set; }

        public int GridPostion { get; set; }

        public Position CurrentPostion { get; set; }

        public virtual Player Player { get; set; }

        public virtual Game Games { get; set; }
    }
}
