using Product.Database.Mongo.Entity;

namespace Product.Database.Mongo.Repository;

public interface IProductRepository
{
    Task AddProduct(ProductEntity p);
    Task<ProductEntity> GetProduct(string ean);

    //Task<bool> AddProductDiscount(List<DiscountEntity> ld);
    //Task<bool> AddProductPrice(List<PriceEntity> lp);
}
