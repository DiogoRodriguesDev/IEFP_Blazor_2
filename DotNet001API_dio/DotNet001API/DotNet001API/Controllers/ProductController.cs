using DotNet001API.Commands;
using DotNet001API.Models;
using DotNet001API.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DotNet001API.Controllers
{
    public class ProductController : Controller
    {

        IMediator Mediator { get; set; }

        public ProductController(IMediator mediator)
        {
            Mediator = mediator;
        }


        [HttpGet("products")]
        public async Task<IActionResult> GetProducts([FromQuery] ProductRequest request)
        {
            var result = await Mediator.Send(new GetProductsQuery
            {
                Search = request.Search
            });
            return Ok(result);
        }

        [HttpGet("product-details/{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var result = await Mediator.Send(new GetProductQuery(new Models.ProductRequest
            {
                Id = id
            }));
            return Ok(result);
        }

        [HttpGet("products/{search}")]
        //public async Task<IActionResult> GetProduct(string search)
        //{
        //    var result = await Mediator.Send(new GetProductQuery(new Models.ProductRequest
        //    {
        //        Search = search
        //    }));
        //    return Ok(result);
        //}
        [HttpPost("products")]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            var result = await Mediator.Send(new AddProductCommand(product));
            return Ok(result);
        }

        [HttpDelete("products/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
             await Mediator.Send(new DeleteProductCommand(id));
            return Ok();
        }
        [HttpPut("products/{id}")]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product, int id)
        {
            await Mediator.Send(new UpdateProductCommand(product, id));

            return Ok();
        }

    }
}
