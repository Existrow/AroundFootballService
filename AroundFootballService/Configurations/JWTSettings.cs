namespace AroundFootballService.Configurations
{
    public class JWTSettings
    {
        public string Secret { get; set; }

        public string ValidAudience { get; set; }

        public string ValidIssuer { get; set; }
    }
}
