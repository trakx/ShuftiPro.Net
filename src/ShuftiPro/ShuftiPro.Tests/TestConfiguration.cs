using Microsoft.Extensions.Configuration;

namespace ShuftiPro.Tests
{
    public static class TestConfiguration
    {
        static TestConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false)
                .AddJsonFile("appsettings.Development.json", true);

            Configuration = builder.Build();
        }

        public static IConfiguration Configuration { get; }
    }
}
