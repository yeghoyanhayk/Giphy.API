using Giphy.Application.UseCases.Giphy.Commands.RequestModels;
using Giphy.Application.UseCases.Giphy.Queries.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Giphy.API.Controllers
{
    public class GiphyController : BaseController
    {
        private readonly IMediator _mediator;
        public GiphyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(GiphyRequest request)
        {

            var response = await _mediator.Send(request);
            if (response.UpdateCache)
            {
                await _mediator.Send(new StoreGiphyRequest 
                { 
                    Giphy = response.Giphy,
                    Path = string.Empty, // Define path by some naming conventions
                    QueryString = request.QueryString // query string should be constructed from request parameters but, let make an abstract from that 
                });
            }

            // Validate and return relevant response with response codes
            return Ok();
        }
    }
}
