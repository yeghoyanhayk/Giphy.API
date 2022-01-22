using Giphy.Application.Abstractions;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Giphy.Infrastructure.ClientFactory
{
    public class GiphyHttpClientFactory : IGiphyHttpClientFactory
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly JsonSerializerOptions _options;

        public GiphyHttpClientFactory(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

            // config JsonSerializer 
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public async Task<T> ExecuteAsync<T>()
        {
            using var httpClient = _httpClientFactory.CreateClient();
            // Make request and return if response is exists
            throw new NotImplementedException();
        }
    }
}
