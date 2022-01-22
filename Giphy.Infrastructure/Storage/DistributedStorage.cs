using Giphy.Application.Abstractions;
using System;
using System.Threading.Tasks;

namespace Giphy.Infrastructure.Storage
{
    public class DistributedStorage : IDistributedStorage
    {
        public Task<bool> AddAsync(string path, object value)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetAsync(string path)
        {
            throw new NotImplementedException();
        }
    }
}
