using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Tests {

    [TestClass]
    public class OfferTests {

        [TestMethod]
        public void ShouldReturnDiscountPercentage() {
            var offer = new Offer(2, 1);
            Assert.AreEqual(33.33, offer.GetDiscountPercent());
        }
    }
}