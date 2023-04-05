using DotNet001Shared;
using DotNet001Shared.Models;
using Refit;

namespace DotNet001BlazorWebApplication.Interfaces
{
    public interface IWebServiceAPI
    {
        [Get("/products")]
        public Task<List<Product>> GetProducts();

        [Get("/product-details/{id}")]
        public Task<Product> GetProduct(int id);

        [Post("/products")]
        public Task<Product> CreateProduct([Body] Product newProduct);

        [Put("/products/{id}")]
        public Task<Product> UpdateProduct(int id, [Body] Product updatedProduct);


        [Delete("/products/{id}")]
        public Task DeleteProduct(int id);
    }
}
