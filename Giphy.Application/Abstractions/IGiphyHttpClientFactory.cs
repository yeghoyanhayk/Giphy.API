using System.Threading.Tasks;

namespace Giphy.Application.Abstractions
{
    public interface IGiphyHttpClientFactory
    {
        Task<T> ExecuteAsync<T>();
    }
}