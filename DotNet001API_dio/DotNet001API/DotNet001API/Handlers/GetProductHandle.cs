using DotNet001API.Queries;
using MediatR;
using DotNet001API.Models;
using DotNet001API.Data;

namespace DotNet001API.Handlers
{
    public class GetProductHandle : IRequestHandler<GetProductQuery, Product>
    {
        IDataContext _dataContext;

        public GetProductHandle(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {

            var query = _dataContext.Products.Where(x =>x.Id == request.ProductRequest.Id).FirstOrDefault();

            return Task.FromResult(query);
        }
    }
}
