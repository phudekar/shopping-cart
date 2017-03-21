using System;

namespace Core
{
    public class Offer
    {
        private int offerQuantity;
        private int freeQuantity;

        public Offer(int offerQuantity, int freeQuantity)
        {
            this.offerQuantity = offerQuantity;
            this.freeQuantity = freeQuantity;
        }

        public double GetDiscountPercent()
        {
            return Math.Round(freeQuantity * 100.0 / (offerQuantity + freeQuantity), 2);
        }
    }
}