using System.ComponentModel.DataAnnotations;

namespace AroundFootballService.Services.Teams.Dto
{
    public class CreateTeamDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }

        [Required]
        public string FlagUrl { get; set; }

        [Required]
        public int RegionId { get; set; }
    }
}
