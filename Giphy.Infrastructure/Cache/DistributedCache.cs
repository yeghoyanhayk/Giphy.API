using Giphy.Application.Abstractions;
using System;
using System.Threading.Tasks;

namespace Giphy.Infrastructure.Cache
{
    class DistributedCache : IDistributedCache
    {
        public Task<bool> AddAsync(string key, object value, DateTimeOffset expirationDate)
        {
            // Important: Lock key to avoid redundancy calls
            // Process object and validate if it important
            throw new NotImplementedException();
        }

        public Task<string> GetAsync(string key)
        {
            throw new NotImplementedException();
        }
    }
}
