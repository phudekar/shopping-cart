using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class Cart
    {
        private IList<Product> products = new List<Product>();

        public bool IsEmpty()
        {
            return !this.products.Any();
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public int GetQuantity()
        {
            return this.products.Count;
        }

        public int GetTotal()
        {
            var total = 0;
            foreach (var product in products)
            {
                total += product.UnitPrice;
            }
            return total;
        }
    }
}