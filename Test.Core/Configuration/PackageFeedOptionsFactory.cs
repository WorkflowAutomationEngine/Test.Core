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

            string? githubActor = Environment.GetEnvironmentVariable("GITHUB_ACTOR");
            string? githubToken = Environment.GetEnvironmentVariable("GITHUB_TOKEN");

            return new PackageFeedOptions
            {
                FeedUrl = options!.FeedUrl,
                Username = Environment.GetEnvironmentVariable("GITHUB_ACTOR")
               ?? options.Username,
                Token = Environment.GetEnvironmentVariable("GITHUB_TOKEN")
            ?? options.Token
            };
        }
    }
}
