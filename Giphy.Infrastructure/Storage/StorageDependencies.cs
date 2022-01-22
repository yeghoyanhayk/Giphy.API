using Microsoft.Extensions.DependencyInjection;

namespace Giphy.Infrastructure.Storage
{
    public static class StorageDependencies
    {
        public static IServiceCollection RegisterDistributedStorage(this IServiceCollection services)
        {
            // register distributed storage like Azure Blob, AWS S3 Bucket, etc.    
            return services;
        }
    }
}
