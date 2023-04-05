using DotNet001API.Models;
using MediatR;
namespace DotNet001API.Commands
{
    public record AddProductCommand(Product product) : IRequest<Product>;
    
}
