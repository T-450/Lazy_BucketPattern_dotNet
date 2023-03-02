namespace BucketPatternTests
{
    using BucketPattern.Buckets;
    using BucketPattern.Interfaces;
    using Microsoft.Extensions.DependencyInjection;
    using NSubstitute;

    public class RepoBucketTests
    {
        /// <summary>
        ///     In this test, we are testing that the RepoBucket class correctly resolves and returns the registered dependencies
        ///     for each IRepository property.
        /// </summary>
        [Fact]
        public void Test_RepoBucket()
        {
            // Arrange
            var serviceCollection = new ServiceCollection();
            var repository1 = Substitute.For<IRepository1>();
            var repository2 = Substitute.For<IRepository2>();
            var repository3 = Substitute.For<IRepository3>();
            var repository4 = Substitute.For<IRepository4>();
            var repository5 = Substitute.For<IRepository5>();
            var repository6 = Substitute.For<IRepository6>();

            // Register dependencies in ServiceCollection
            serviceCollection.AddSingleton(repository1);
            serviceCollection.AddSingleton(repository2);
            serviceCollection.AddSingleton(repository3);
            serviceCollection.AddSingleton(repository4);
            serviceCollection.AddSingleton(repository5);
            serviceCollection.AddSingleton(repository6);

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            // Act
            var repoBucket = new RepoBucket(serviceProvider);

            // Assert
            Assert.Same(repository1, repoBucket.Repo1);
            Assert.Same(repository2, repoBucket.Repo2);
            Assert.Same(repository3, repoBucket.Repo3);
            Assert.Same(repository4, repoBucket.Repo4);
            Assert.Same(repository5, repoBucket.Repo5);
            Assert.Same(repository6, repoBucket.Repo6);
        }
    }
}