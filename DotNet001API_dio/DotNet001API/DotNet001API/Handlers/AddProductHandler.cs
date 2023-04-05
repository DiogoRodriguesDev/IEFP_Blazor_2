using DotNet001API.Commands;
using DotNet001API.Data;
using DotNet001API.Models;
using MediatR;

namespace DotNet001API.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
    {
        IDataContext _dataContext;

        public AddProductHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = _dataContext.Products;

            if(product == null)
            {
                return null;
            }
            else
            {
                try
                {
                    await product.AddAsync(request.product);
                    await _dataContext.SaveChangesAsync(cancellationToken);

                    return request.product;
                }
                catch (Exception e)
                {

                    throw;
                }
            }


        }
    }
}
