namespace AroundFootballService.Configurations.Extensions
{
    public static class AppExtensions
    {
        public static T GetConfigurationObject<T>(this IConfiguration configuration)
            => configuration.GetSection(typeof(T).Name).Get<T>();
    }
}
