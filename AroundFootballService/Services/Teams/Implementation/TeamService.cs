using AroundFootballService.Data;
using AroundFootballService.Data.Models;
using AroundFootballService.Services.Interfaces;
using AroundFootballService.Services.Teams.Dto;
using Microsoft.EntityFrameworkCore;

namespace AroundFootballService.Services
{
    public class TeamService: ITeamService
    {
        private readonly DataContext dataContext;

        public TeamService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void CreateTeam(CreateTeamDto teamDto)
        {
            var transaction = dataContext.Database.BeginTransaction();
            try
            {
                if (!dataContext.Regions.Any(t => t.Id == teamDto.RegionId))
                {                
                    throw new Exception();
                }

                if (dataContext.Teams.Any(team => team.Name.Equals(teamDto.Name)))
                {
                    throw new Exception();
                }

                var newTeam = new Team()
                {
                    CountryCode = teamDto.CountryId,
                    Name = teamDto.Name,
                    FlagUrl = teamDto.FlagUrl,
                    Region = new Region() { Id = teamDto.RegionId }
                };

                dataContext.Teams.Add(newTeam);
                dataContext.SaveChanges();

                transaction.Commit();           
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
        }

        public void DeleteTeam(int teamId)
        {
            var transaction = dataContext.Database.BeginTransaction();
            try
            {
                var team = dataContext.Teams.FirstOrDefault(t => t.Id == teamId);
                if(team == null)
                {
                    throw new Exception();
                }
                dataContext.Teams.Remove(team);
                dataContext.SaveChanges();

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
        }

        public IEnumerable<TeamDto> GetTeams()
        {
            try
            {
                //TODO: убрать как определимся с маппером
                var teams = dataContext.Teams.Select(team => new TeamDto
                {
                    Id = team.Id,
                    Name = team.Name,
                    CountryId = team.CountryCode,
                    FlagUrl = team.FlagUrl,
                });

                return teams;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TeamDto GetTeamById(int id)
        {
            var team = dataContext.Teams.FirstOrDefault(t => t.Id == id);
            if(team == null)
            {
                throw new Exception();
            }

            return new TeamDto
            {
                Id = team.Id,
                Name = team.Name,
                CountryId = team.CountryCode,
                RegionId = team.Region.Id,
            };
        }

        public void UpdateTeam(TeamDto teamDto)
        {
            var transaction = dataContext.Database.BeginTransaction();
            try
            {
                if (!dataContext.Regions.Any(t => t.Id == teamDto.RegionId))
                {
                    throw new Exception();
                }

                if (dataContext.Teams.Any(team => team.Name.Equals(teamDto.Name)))
                {
                    throw new Exception();
                }

                var team = dataContext.Teams.FirstOrDefault(t => t.Id == teamDto.Id);
                if (team == null)
                {
                    throw new Exception();
                }

                var newTeam = new Team()
                {
                    Id = teamDto.Id,
                    Name = teamDto.Name,
                    CountryCode = teamDto.CountryId,
                    Region = new Region() { Id = teamDto.RegionId }
                };

                dataContext.Entry(newTeam).State = EntityState.Modified;                         
                dataContext.SaveChanges();

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
        }
    }
}
