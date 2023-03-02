// See https://aka.ms/new-console-template for more information

using BucketPattern.Buckets;
using BucketPattern.Implementation;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

var service = new Service(new RepoBucket(serviceProvider));

await service.MethodAsync();
