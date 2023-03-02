namespace BucketPattern.Buckets
{
    using Interfaces;
    using Microsoft.Extensions.DependencyInjection;

    public class RepoBucket : IRepoBucket
    {
        private readonly Lazy<IRepository1> _lazyRepo1;
        private readonly Lazy<IRepository2> _lazyRepo2;
        private readonly Lazy<IRepository3> _lazyRepo3;
        private readonly Lazy<IRepository4> _lazyRepo4;
        private readonly Lazy<IRepository5> _lazyRepo5;
        private readonly Lazy<IRepository6> _lazyRepo6;

        private readonly IServiceProvider _serviceProvider;

        public RepoBucket(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _lazyRepo1 = GetInstance<IRepository1>();
            _lazyRepo2 = GetInstance<IRepository2>();
            _lazyRepo3 = GetInstance<IRepository3>();
            _lazyRepo4 = GetInstance<IRepository4>();
            _lazyRepo5 = GetInstance<IRepository5>();
            _lazyRepo6 = GetInstance<IRepository6>();
        }

        public IRepository1 Repo1 => _lazyRepo1.Value;
        public IRepository2 Repo2 => _lazyRepo2.Value;
        public IRepository3 Repo3 => _lazyRepo3.Value;
        public IRepository4 Repo4 => _lazyRepo4.Value;
        public IRepository5 Repo5 => _lazyRepo5.Value;
        public IRepository6 Repo6 => _lazyRepo6.Value;

        public void Deconstruct(out Lazy<IRepository1> lazyRepo1,
            out Lazy<IRepository2> lazyRepo2,
            out Lazy<IRepository3> lazyRepo3,
            out Lazy<IRepository4> lazyRepo4,
            out Lazy<IRepository5> lazyRepo5,
            out Lazy<IRepository6> lazyRepo6)
        {
            lazyRepo1 = _lazyRepo1;
            lazyRepo2 = _lazyRepo2;
            lazyRepo3 = _lazyRepo3;
            lazyRepo4 = _lazyRepo4;
            lazyRepo5 = _lazyRepo5;
            lazyRepo6 = _lazyRepo6;
        }

        private Lazy<T> GetInstance<T>()
            =>  new(_serviceProvider.GetRequiredService<T>());
    }
}
