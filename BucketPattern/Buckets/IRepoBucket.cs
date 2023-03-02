namespace BucketPattern.Buckets
{
    using Interfaces;

    public interface IRepoBucket
    {
        IRepository1 Repo1 { get; }
        IRepository2 Repo2 { get; }
        IRepository3 Repo3 { get; }
        IRepository4 Repo4 { get; }
        IRepository5 Repo5 { get; }
        IRepository6 Repo6 { get; }
    }
}
