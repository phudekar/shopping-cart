using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class Cart
    {
        private IDictionary<Product, int> products = new Dictionary<Product, int>();

        public bool IsEmpty()
        {
            return !this.products.Any();
        }

        public void AddProduct(Product product)
        {
            if (this.products.ContainsKey(product))
            {
                this.products[product] += 1;
            }
            else
            {
                this.products.Add(product, 1);
            }
        }

        public int GetQuantity(Product product)
        {
            return this.products[product];
        }

        public double GetTotal()
        {
            var total = 0.0;
            foreach (var product in products.Keys)
            {
                var quantity = products[product];

                total += product.UnitPrice * quantity;
                if (product.Offer != null)
                {
                    total -= Math.Round(product.UnitPrice * quantity * product.Offer.GetDiscountPercent() / 100,2);
                }
            }
            return total;
        }
    }
}