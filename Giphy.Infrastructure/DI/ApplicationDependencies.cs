using Giphy.Application.Abstractions;
using Giphy.Infrastructure.Cache;
using Giphy.Infrastructure.ClientFactory;
using Giphy.Infrastructure.Storage;
using Giphy.Persistence.DbContext;
using Giphy.Persistence.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Giphy.Infrastructure.DI
{
    public static class ApplicationDependencies
    {
        // This method can be separated
        public static IServiceCollection RegisterAllDependencies(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IApplicationDbContext, ApplicationDbContext>();

            services.AddTransient<IDistributedStorage, DistributedStorage>();
            services.AddTransient<IDistributedCache, DistributedCache>();

            services.AddHttpClient<IGiphyHttpClientFactory, GiphyHttpClientFactory>();
            return services;
        }
    }
}
