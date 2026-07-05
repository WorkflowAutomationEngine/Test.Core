using NuGet.Versioning;

namespace Test.Core.Services
{
    public interface IPackageVersionSource
    {
        Task<IReadOnlyList<NuGetVersion>> GetVersionsAsync(
            string packageId,
            CancellationToken cancellationToken = default);
    }

}
