using System;
using System.Threading.Tasks;

namespace Giphy.Application.Abstractions
{
    public interface IDistributedCache
    {
        Task<string> GetAsync(string key);
        Task<bool> AddAsync(string key, object value, DateTimeOffset expirationDate);
    }
}
