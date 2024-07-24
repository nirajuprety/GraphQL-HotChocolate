using GraphQLHotChocolate.Entities;
using GraphQLHotChocolate.Repositories;

namespace GraphQLHotChocolate.GraphQL.Queries
{
    public class ProductQueryTypes
    {
        public async Task<List<ProductDetails>> GetProductListAsync([Service] IProductService productService)
        {
            return await productService.ProductListAsync();
        }
        //
        public async Task<ProductDetails> GetProductDetailsByIdAsync([Service] IProductService productService, int productId)
        {
            var result = await productService.GetProductDetailByIdAsync(productId);
            return result;
        }
        
      }
}
