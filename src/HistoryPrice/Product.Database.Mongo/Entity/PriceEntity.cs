using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Product.Database.Mongo.Entity;

public class PriceEntity
{
    public PriceEntity(string ean, int price, DateTime startDate, DateTime endDate)
    {
        this.StartDate = startDate;
        this.EndDate = endDate;
        this.Ean = ean;
        this.ActualPrice = price;
    }

    [BsonRepresentation(BsonType.String)]
    public string Ean { get; set; }
    [BsonRepresentation(BsonType.Double)]
    public double ActualPrice { get; set; }
    [BsonRepresentation(BsonType.DateTime)]
    public DateTime StartDate { get; set; }
    [BsonRepresentation(BsonType.DateTime)]
    public DateTime EndDate { get; set; }
}
