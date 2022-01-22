using Giphy.Application.UseCases.Giphy.Commands.Models;
using MediatR;

namespace Giphy.Application.UseCases.Giphy.Commands.RequestModels
{
    public class StoreGiphyRequest : IRequest<StoreGiphyResponse>
    {
        public string QueryString { get; set; }
        public string Path { get; set; }
        public object Giphy { get; set; }
    }
}
