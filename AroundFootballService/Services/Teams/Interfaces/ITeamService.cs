using AroundFootballService.Services.Teams.Dto;

namespace AroundFootballService.Services.Interfaces
{
    public interface ITeamService
    {
        public void CreateTeam(CreateTeamDto teamDto);

        public void UpdateTeam(TeamDto teamDto);

        public void DeleteTeam(int teamId);

        public IEnumerable<TeamDto> GetTeams();

        public TeamDto GetTeamById(int id);
    }
}
