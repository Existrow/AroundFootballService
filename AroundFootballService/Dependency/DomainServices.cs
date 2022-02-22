using AroundFootballService.Services;
using AroundFootballService.Services.Interfaces;

namespace AroundFootballService.Dependency
{
    public static class DomainServices
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<ITeamService, TeamService>();

            return services;
        }
    }
}
