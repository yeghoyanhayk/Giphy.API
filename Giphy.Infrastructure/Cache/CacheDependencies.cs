using Microsoft.Extensions.DependencyInjection;

namespace Giphy.Infrastructure.Cache
{
    public static class CacheDependencies
    {
        public static IServiceCollection RegisterDistributedCache(this IServiceCollection services)
        {
            // register distributed cache like Redis, Eh-cache, Memcache, Riak, Hazelcast, etc.
            return services;
        }
    }
}
