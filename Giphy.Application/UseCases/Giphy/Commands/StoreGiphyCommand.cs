using Giphy.Application.UseCases.Giphy.Commands.Models;
using Giphy.Application.UseCases.Giphy.Commands.RequestModels;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Giphy.Application.UseCases.Giphy.Commands
{
    public class StoreGiphyCommand : IRequestHandler<StoreGiphyRequest, StoreGiphyResponse>
    {
        public async Task<StoreGiphyResponse> Handle(StoreGiphyRequest request, CancellationToken cancellationToken)
        {
            // Step 1: Update cache
            // Step 2: Update storage if file is not exists
            // Step 3: Insert to Db if files metadata is not exists

            throw new NotImplementedException();
        }
    }
}
