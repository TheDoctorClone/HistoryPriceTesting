using Product.Database.Mongo.Entity;

namespace Product.Database.Mongo.Repository;

public interface IProductRepository
{
    Task<bool> AddProduct(ProductEntity p);
    Task<ProductEntity> GetProduct(string ean);

    Task<bool> AddProductDiscount(string ean, List<Discount> ld);
    Task<bool> AddProductPrice(string ean, List<Price> lp);
}
