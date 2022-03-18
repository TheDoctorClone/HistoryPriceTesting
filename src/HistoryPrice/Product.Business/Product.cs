namespace Product.Business
{
    public class Product
    {
        public Product(string name, string ean, DateTime? expireDate = null)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrEmpty(ean))
                throw new ArgumentNullException(nameof(ean));

            this.Name = name;
            this.Ean = ean;
            this.ExpireDate = expireDate;

            this.Prices = new List<Price>();
            this.Discounts = new List<Discount>();
        }

        public string Ean { get; }
        public string Name { get; }
        public DateTime? ExpireDate { get; }

        List<Price> Prices { get; set; }
        List<Discount> Discounts { get; set; }

        public void AddPrice(double price, DateTime startDate, DateTime endDate)
        {
            //TODO verificare che il range di date non collida con quelle già presenti
            this.Prices.Add(new Price(price, startDate, endDate));
        }

        public void AddDiscount(int discount, DateTime startDate, DateTime endDate)
        {
            //TODO verificare che il range di date non collida con quelle già presenti
            this.Discounts.Add(new Discount(discount, startDate, endDate));
        }
    }
}