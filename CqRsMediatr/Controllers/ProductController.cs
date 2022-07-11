using CqRsMediatr.Features.Products;
using CqRsMediatr.Features.Products.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CqRsMediatr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<GetProductQueryResponse> GetProducts() => _mediator.Send(new GetProductQuery());


        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpGet("{ProductId}")]
        public Task<GetProductQueryResponse> GetProductById([FromRoute] GetProductQuery query) =>
       _mediator.Send(query);
    }
}
