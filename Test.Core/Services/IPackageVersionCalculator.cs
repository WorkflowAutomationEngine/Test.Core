using NuGet.Versioning;

namespace Test.Core.Services
{
    public interface IPackageVersionCalculator
    {
        NuGetVersion GetNextVersion(
        string versionPrefix,
        IReadOnlyList<NuGetVersion> publishedVersions);
    }
}
