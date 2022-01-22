using Giphy.Application.Abstractions;
using Giphy.Application.UseCases.Giphy.Queries.Models;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Giphy.Application.UseCases.Gif.Queries
{
    public class GiphyQuery : IRequestHandler<GiphyRequest, GiphyResponse>
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IDistributedStorage _distributedStorage;
        private readonly IGiphyHttpClientFactory _giphyHttpClientFactory;
        private readonly IRepository<Domain.Entities.Giphy> _repository;
        public GiphyQuery(IDistributedCache distributedCache,
                          IRepository<Domain.Entities.Giphy> repository,
                          IDistributedStorage distributedStorage,
                          IGiphyHttpClientFactory giphyHttpClientFactory)
        {
            _distributedCache = distributedCache;
            _repository = repository;
            _distributedStorage = distributedStorage;
            _giphyHttpClientFactory = giphyHttpClientFactory;
        }


        public async Task<GiphyResponse> Handle(GiphyRequest request, CancellationToken cancellationToken)
        {
            var response = default(object);
            var giphyResponse = new GiphyResponse();

            // Step 1: check cache
            var storagePath = await _distributedCache.GetAsync(request.QueryString);
            if (string.IsNullOrWhiteSpace(storagePath))
            {
                // Step 2: check db and notify to update cache
                var giphy = (await _repository.GetAsync(x => x.QueryString == request.QueryString)).FirstOrDefault();
                if (giphy != null)
                {
                    storagePath = giphy.StoragePath;
                }
            }

            if (!string.IsNullOrWhiteSpace(storagePath))
            {
                response = await _distributedStorage.GetAsync(storagePath);
                // here some validation
            }
            else
            {
                // Returns object because it is an example. In production, we should define response type
                response = await _giphyHttpClientFactory.ExecuteAsync<object>();
                // here some validation
                giphyResponse.UpdateCache = true;
            }

            giphyResponse.Giphy = response;
            return giphyResponse;
        }
    }
}
