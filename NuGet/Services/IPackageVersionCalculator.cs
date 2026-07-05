using NuGet.Versioning;

namespace Test.Core.NuGet.Services
{
    public interface IPackageVersionCalculator
    {
        NuGetVersion GetNextVersion(
        string versionPrefix,
        IReadOnlyList<NuGetVersion> publishedVersions);
    }
}
