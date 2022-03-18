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
        }

        public string Ean { get; }
        public string Name { get; }
        public DateTime? ExpireDate { get; }

        List<Price> Prices { get; set; }
        List<Discount> Discounts { get; set; }

        public void AddPrice()
        {
            throw new NotImplementedException();
        }

        public void AddDiscount()
        {
            throw new NotImplementedException();
        }
    }
}