namespace Product.Business;

public class Price
{
    public Price(double? price, DateTime? startDate, DateTime? endDate)
    {
        if (price == null)
            throw new ArgumentNullException(nameof(price));
        if (price <= 0)
            throw new Exception("invalid price");
        if (startDate == null)
            throw new ArgumentNullException(nameof(startDate));
        if (endDate == null)
            throw new ArgumentNullException(nameof(endDate));

        this.ActualPrice = price;
        this.StartDate = startDate;
        this.EndDate = endDate;
    }

    public double? ActualPrice { get; }
    public DateTime? StartDate { get; }
    public DateTime? EndDate { get; }
}
