namespace BucketPatternTests
{
    using BucketPattern.Buckets;
    using BucketPattern.Implementation;
    using BucketPattern.Interfaces;
    using NSubstitute;

    public class ServiceBucketTests
    {
        [Fact]
        public async Task Test_MethodAsync()
        {
            // Arrange
            var repoBucket = Substitute.For<IRepoBucket>();
            var repository1 = Substitute.For<IRepository1>();
            repository1.GetInfo().Returns("Test info");
            repoBucket.Repo1.Returns(repository1);
            var service = new Service(repoBucket);

            // Act
            string result = await service.MethodAsync();

            // Assert
            Assert.Equal("Test info", result);
        }
    }
}