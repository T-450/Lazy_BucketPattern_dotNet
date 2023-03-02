namespace BucketPattern.Implementation
{
    using Buckets;
    using Interfaces;

    public class Service : IService
    {
        private readonly IRepoBucket _repoBucket;

        public Service(IRepoBucket repoBucket)
        {
            _repoBucket = repoBucket;
        }

        public Task<string> MethodAsync()
        {
            return Task.FromResult(_repoBucket.Repo1.GetInfo());
        }
    }
}
