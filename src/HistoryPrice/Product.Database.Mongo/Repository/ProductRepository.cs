using MongoDB.Driver;
using Product.Database.Mongo.Entity;

namespace Product.Database.Mongo.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMongoClient _mongoClient;
        private readonly string _database = "HistoryPrice";
        private readonly string _collectionName = "Product";
        private readonly IMongoCollection<ProductEntity> Collection;

        public ProductRepository(IMongoClient _mongoClient)
        {
            if (_mongoClient == null)
                throw new ArgumentNullException(nameof(_mongoClient));

            this._mongoClient = _mongoClient;

            if (!this._mongoClient.GetDatabase(_database).ListCollectionNames().ToList().Contains(_collectionName))
                this._mongoClient.GetDatabase(_database).CreateCollection(_collectionName);

            Collection = this._mongoClient.GetDatabase(_database).GetCollection<ProductEntity>(_collectionName);
        }

        public async Task AddProduct(ProductEntity p)
        {
            await Collection.InsertOneAsync(p);
        }

        //public Task<bool> AddProductDiscount(List<DiscountEntity> ld)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> AddProductPrice(List<PriceEntity> lp)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<ProductEntity> GetProduct(string ean)
        {
            var builder = Builders<ProductEntity>.Filter;
            var filter = builder.Eq(p => p.Ean, ean);
            return await Collection.Find(filter).FirstOrDefaultAsync();
        }
    }
}