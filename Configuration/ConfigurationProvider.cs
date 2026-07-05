using Microsoft.Extensions.Configuration;

namespace Test.Core.Configuration
{
    public static class ConfigurationProvider
    {
        public static IConfigurationRoot Build()
        {
            return new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();
        }
    }
}
