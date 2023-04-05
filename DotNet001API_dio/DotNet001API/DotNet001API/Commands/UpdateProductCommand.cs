using DotNet001API.Models;
using MediatR;

namespace DotNet001API.Commands
{
    public record UpdateProductCommand(Product Product, int Id) : IRequest<Product>;
   
}
