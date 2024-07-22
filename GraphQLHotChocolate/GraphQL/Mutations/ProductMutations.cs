using GraphQLHotChocolate.Entities;
using GraphQLHotChocolate.Repositories;
using GraphQLHotChocolate.Response;

namespace GraphQLHotChocolate.GraphQL.Mutations
{
    public class ProductMutations
    {
        
        public async Task<bool> AddProductAsync([Service] IProductService productService,
    ProductDetails productDetails)
        {
            return await productService.AddProductAsync(productDetails);
        }

        public async Task<bool> UpdateProductAsync([Service] IProductService productService,
    ProductDetails productDetails)
        {
            return await productService.UpdateProductAsync(productDetails);
        }

        public async Task<bool> DeleteProductAsync([Service] IProductService productService,  int productId)
        {
            return await productService.DeleteProductAsync(productId);
        }


        public async Task<ProductResponse> AddProductWithResponseModelAsync([Service] IProductService productService,
  ProductDetails productDetails)
        {
            bool status =  await productService.AddProductAsync(productDetails);
            var result = new ProductResponse()
            {
                Status = status,
                ProductDescription = productDetails.ProductDescription,
                ProductName = productDetails.ProductName,
                ProductPrice = productDetails.ProductPrice,
                ProductStock = productDetails.ProductStock,
            };
            return result;
        }

        public async Task<ExecuteResult> AddProductAsync([Service] IProductService productService,
  ProductDetails productDetails)
        {
            if (productDetails.ProductPrice < 0) return new ExecuteResult()
            {
                Message = "Price is less",
                Status = ResponseStatus.Failure
            };
            var result = await productService.AddProductAsync(productDetails);
            return new ExecuteResult()
            {
                Message = "Added Successfully",
                Status = ResponseStatus.Success
            };
        }
    }
}
