using System.Threading.Tasks;

namespace Giphy.Application.Abstractions
{
    public interface IDistributedStorage
    {
        Task<object> GetAsync(string path);
        Task<bool> AddAsync(string path, object value);
    }
}
