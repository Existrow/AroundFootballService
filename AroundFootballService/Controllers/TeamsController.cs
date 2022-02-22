using AroundFootballService.Services.Interfaces;
using AroundFootballService.Services.Teams.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AroundFootballService.Controllers
{
    [Route("api/teams")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _teamsService;
        public TeamsController(ITeamService teamsService)
        {
            _teamsService = teamsService;
        }

        [HttpGet]
        public IEnumerable<TeamDto> GetTeams()
        {
            try
            {
                return _teamsService.GetTeams();
            }
            catch (Exception ex)
            {
                //пока хз как обрабатывать лучше всего ошибки
                throw;
            }
        }
       
        [HttpGet("read/{id}")]
        public TeamDto GetTeamById(int id)
        {
            try
            {
                return _teamsService.GetTeamById(id);
            }
            catch (Exception ex)
            {
                //пока хз как обрабатывать лучше всего ошибки
                throw;
            }
        }
        
        [HttpPost]
        public void CreateTeam([FromBody] CreateTeamDto teamDto)
        {
            try
            {
                _teamsService.CreateTeam(teamDto);
            }
            catch (Exception ex)
            {
                //пока хз как лучше всего обрабатывать ошибки
                throw;
            }
        }
        
        [HttpPut]
        public void UpdateTeam([FromBody] TeamDto teamDto)
        {
            try
            {
                _teamsService.UpdateTeam(teamDto);
            }
            catch (Exception ex)
            {
                //пока хз как лучше всего обрабатывать ошибки
                throw;
            }
        }
       
        [HttpDelete]
        public void DeleteTeam([FromBody] DeleteTeamDto dto)
        {
            try
            {
                _teamsService.DeleteTeam(dto.TeamId);
            }
            catch (Exception ex)
            {
                //пока хз как лучше всего обрабатывать ошибки
                throw;
            }
        }
    }
}
