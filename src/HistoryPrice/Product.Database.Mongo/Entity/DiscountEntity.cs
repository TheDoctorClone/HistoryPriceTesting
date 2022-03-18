using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Product.Database.Mongo.Entity;

public class DiscountEntity
{
    public DiscountEntity(string ean, int discount, DateTime startDate, DateTime endDate)
    {
        this.StartDate = startDate;
        this.EndDate = endDate;
        this.Ean = ean;
        this.ActualDiscount = discount;
    }

    [BsonRepresentation(BsonType.String)]
    public string Ean { get; set; }
    [BsonRepresentation(BsonType.Int32)]
    public int ActualDiscount { get; set; }
    [BsonRepresentation(BsonType.DateTime)]
    public DateTime StartDate { get; set; }
    [BsonRepresentation(BsonType.DateTime)]
    public DateTime EndDate { get; set; }
}
