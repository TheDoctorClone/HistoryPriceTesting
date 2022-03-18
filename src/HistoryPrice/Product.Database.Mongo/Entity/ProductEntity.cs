using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Product.Database.Mongo.Entity;

public class ProductEntity
{
    //ipotizzo di mettere le 3 entità in 3 tabelle diverse
    //saranno legate dall'ean
    //in fase di lettura aggrego i dati
    public ProductEntity(string ean, string name)
    {
        this.Name = name;
        this.Ean = ean;
        //this.Prices = new List<Price>();
        //this.Discounts = new List<Discount>();
    }

    [BsonRepresentation(BsonType.String)]
    public string Ean { get; set; }
    [BsonRepresentation(BsonType.String)]
    public string Name { get; set; }
    [BsonRepresentation(BsonType.DateTime)]
    public DateTime? ExpireDate { get; set; }

    //List<Price> Prices { get; set; }
    //List<Discount> Discounts { get; set; }
}

//public class Price
//{
//    [BsonRepresentation(BsonType.String)]
//    public string Ean { get; set; }
//    [BsonRepresentation(BsonType.Double)]
//    public double ActualPrice { get; set; }
//    [BsonRepresentation(BsonType.DateTime)]
//    public DateTime StartDate { get; set; }
//    [BsonRepresentation(BsonType.DateTime)]
//    public DateTime EndDate { get; set; }
//}

//public class Discount
//{
//    [BsonRepresentation(BsonType.String)]
//    public string Ean { get; set; }
//    [BsonRepresentation(BsonType.Int32)]
//    public int ActualDiscount { get; set; }
//    [BsonRepresentation(BsonType.DateTime)]
//    public DateTime StartDate { get; set; }
//    [BsonRepresentation(BsonType.DateTime)]
//    public DateTime EndDate { get; set; }
//}
