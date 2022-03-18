using Product.Database.Mongo.Entity;

namespace Product.Database.Mongo.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Task<bool> AddProduct(ProductEntity p)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddProductDiscount(string ean, List<Discount> ld)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddProductPrice(string ean, List<Price> lp)
        {
            throw new NotImplementedException();
        }

        public Task<ProductEntity> GetProduct(string ean)
        {
            throw new NotImplementedException();
        }
    }
}