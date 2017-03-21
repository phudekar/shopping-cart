namespace Core {
    public class Product
    {
        private string name;
        public Product(string name, int unitPrice)
        {
            this.name = name;
            this.UnitPrice = unitPrice;
        }

        public int UnitPrice { get; private set; }
    }
}