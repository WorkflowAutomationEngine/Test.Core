using NuGet.Versioning;
using Test.Core.Configuration;
using Test.Core.Models;
using Test.Core.Services;

PackageFeedOptions options = PackageFeedOptionsFactory.Create(ConfigurationProvider.Build());

IPackageVersionSource versionSource = new PackageVersionSource(options);
IPackageVersionCalculator calculator = new PackageVersionCalculator();

PackageVersionService service = new(versionSource, calculator);

NuGetVersion version = await service.GetNextVersionAsync(
    "Test.Core",
    "1.1.0");

Console.WriteLine(version);
Console.WriteLine(version.Version.Revision);
Console.WriteLine(
    $"{version.Major}.{version.Minor}.{version.Patch}.{version.Revision}");