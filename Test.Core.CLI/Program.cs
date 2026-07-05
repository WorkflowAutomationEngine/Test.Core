using NuGet.Versioning;
using Test.Core.Configuration;
using Test.Core.Models;
using Test.Core.Services;


BuildPropertiesReader reader = new BuildPropertiesReader();

//var path = $"{AppContext.BaseDirectory}\\..\\NuGet\\build.props";
var buildProperties = reader.Read(@"..\..\..\..\NuGet\build.props");

PackageFeedOptions options = PackageFeedOptionsFactory.Create(ConfigurationProvider.Build());

IPackageVersionSource versionSource = new PackageVersionSource(options);
IPackageVersionCalculator calculator = new PackageVersionCalculator();

PackageVersionService service = new(versionSource, calculator);

NuGetVersion version = await service.GetNextVersionAsync(
    buildProperties.PackageId,
    buildProperties.VersionPrefix);

Console.WriteLine($"{version.Major}.{version.Minor}.{version.Patch}.{version.Revision}");