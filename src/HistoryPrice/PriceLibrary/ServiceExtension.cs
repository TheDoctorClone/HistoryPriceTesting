using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using Product.Database.Mongo.Repository;

namespace PriceLibrary;

public static class ServicesExtension
{
    public static IServiceCollection AddPriceLibraryDI(this IServiceCollection services, string mongodbServer, string login, string password)
    {
        services.AddSingleton<IMongoClient>(c =>
        {
            password = Uri.EscapeDataString(password);

            //return new MongoClient($"mongodb+srv://{login}:{password}@{mongodbServer}/test?retryWrites=true&w=majority");
            return new MongoClient($"mongodb://{mongodbServer}");
        });

        services.AddScoped(c => c.GetService<IMongoClient>().StartSession());

        services.AddSingleton<IProductRepository, ProductRepository>();

        return services;
    }
}
