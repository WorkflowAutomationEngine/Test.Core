using NuGet.Versioning;

namespace Test.Core.NuGet.Services
{
    public interface IPackageVersionSource
    {
        Task<IReadOnlyList<NuGetVersion>> GetVersionsAsync(
            string packageId,
            CancellationToken cancellationToken = default);
    }

}
