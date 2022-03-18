namespace Product.Business;

public class Discount
{
    public Discount(int? discount, DateTime? startDate, DateTime? endDate)
    {
        if (discount == null)
            throw new ArgumentNullException(nameof(discount));
        if (discount < 5 || discount > 50 || discount % 5 != 0)
            throw new ArgumentOutOfRangeException(nameof(discount));
        if (startDate == null)
            throw new ArgumentNullException(nameof(startDate));
        if (endDate == null)
            throw new ArgumentNullException(nameof(endDate));

        this.StartDate = startDate;
        this.EndDate = endDate;
        this.ActualDiscount = discount;
    }

    public int? ActualDiscount { get; }
    public DateTime? StartDate { get; }
    public DateTime? EndDate { get; }
}
