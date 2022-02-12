using AroundFootballService.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AroundFootballService.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<Participant> Participants { get; set; }

        public DbSet<StartingGrid> StartingGrids { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>(game =>
            {
                game.HasOne(game => game.ParticipantHome)
                    .WithMany(participant => participant.HomeGames);

                game.HasOne(game => game.ParticipantAway)
                    .WithMany(participant => participant.AwayGames);
            });
        }
    }
}
