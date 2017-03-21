namespace Core {
    public class Product
    {
        private string name;

        public Product(string name, int unitPrice, Offer offer = null)
        {
            this.name = name;
            this.UnitPrice = unitPrice;
            this.Offer = offer;
        }

        public int UnitPrice { get; private set; }
        public Offer Offer { get; internal set; }
    }
}