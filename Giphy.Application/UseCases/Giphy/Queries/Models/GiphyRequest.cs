using MediatR;

namespace Giphy.Application.UseCases.Giphy.Queries.Models
{
    public class GiphyRequest : IRequest<GiphyResponse>
    {
        // query string should be constructed from request parameters but, let make an abstract from that 
        public string QueryString { get; set; }
    }
}
