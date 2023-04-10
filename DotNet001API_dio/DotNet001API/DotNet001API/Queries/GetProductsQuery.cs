using DotNet001API.Models;
using MediatR;
//using Product = DotNet001Shared.Models.Product;
namespace DotNet001API.Queries
{
    public record GetProductsQuery : IRequest<List<Product>>
    {
        public string? Search { get; set; }
        public bool? IsDeleted { get; set; }
    }
   
}
