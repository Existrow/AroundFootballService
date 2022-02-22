using System.ComponentModel.DataAnnotations;

namespace AroundFootballService.Services.Teams.Dto
{
    public class TeamDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }

        [Required]
        public string FlagUrl { get; set; }

        public int RegionId { get; set; }
    }
}
