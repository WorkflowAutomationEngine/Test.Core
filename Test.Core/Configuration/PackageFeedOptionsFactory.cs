using Microsoft.Extensions.Configuration;
using Test.Core.Models;

namespace Test.Core.Configuration
{
    public static class PackageFeedOptionsFactory
    {
        public static PackageFeedOptions Create(IConfiguration configuration)
        {
            PackageFeedOptions? options =
                configuration.GetSection("PackageFeed")
                             .Get<PackageFeedOptions>();

            return options
                ?? throw new InvalidOperationException(
                    "PackageFeed configuration section is missing.");
        }
    }
}
