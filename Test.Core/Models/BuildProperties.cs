namespace Test.Core.Models
{
    public sealed class BuildProperties
    {
        public required string PackageId { get; init; }

        public required string VersionPrefix { get; init; }
    }
}
