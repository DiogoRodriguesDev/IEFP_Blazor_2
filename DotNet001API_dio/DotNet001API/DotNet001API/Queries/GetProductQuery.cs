using MediatR;
using DotNet001API.Models;


namespace DotNet001API.Queries
{
    public record GetProductQuery(ProductRequest ProductRequest) : IRequest<Product>;
  
}
