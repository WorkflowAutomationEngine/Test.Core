using NuGet.Versioning;
using Test.Core.Configuration;
using Test.Core.Services;

namespace Test.Core.Tests
{
    public class PackageFeedVersionSourceTests
    {

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void GetNextVersion_WhenNoPublishedVersions_ShouldReturnRevisionZero()
        {
            // Arrange
            IPackageVersionCalculator calculator = new PackageVersionCalculator();

            // Act
            NuGetVersion version = calculator.GetNextVersion(
                "1.0.0",
                []);

            // Assert
            Assert.Equal(
                new NuGetVersion(1, 0, 0, 0),
                version);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Fact(Skip = "It is integration test")]
        public async Task GetVersionsAsync_ShouldReturnPackageVersions()
        {
            // Arrange
            var configuration = ConfigurationProvider.Build();

            var options = PackageFeedOptionsFactory.Create(configuration);

            var source = new PackageVersionSource(options);

            // Act
            var versions = await source.GetVersionsAsync("Test.Core");

            // Assert
            Assert.NotNull(versions);

            foreach (var version in versions)
            {
                Console.WriteLine(version);
            }
        }
    }
}
