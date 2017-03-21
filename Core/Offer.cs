using System;

namespace Core
{
    public class Offer
    {
        private int purchasedQuantity;
        private int freeQuantity;

        public Offer(int purchasedQuantity, int freeQuantity)
        {
            this.purchasedQuantity = purchasedQuantity;
            this.freeQuantity = freeQuantity;
        }

        public double GetDiscountPercent()
        {
            return Math.Round(freeQuantity * 100.0 / (purchasedQuantity + freeQuantity), 2);
        }
    }
}