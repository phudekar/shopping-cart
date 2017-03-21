using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;

namespace Core.Tests
{
    [TestClass]
    public class CartTests
    {
        private Product deo;
        private Product soap;

        [TestInitialize]
        public void Before()
        {
            deo = new Product("Deo", 100);
            soap = new Product("Soap", 30);
        }

        [TestMethod]
        public void ShouldBeEmptyWhenCreated()
        {
            var cart = new Cart();
            Assert.IsTrue(cart.IsEmpty());
        }

        [TestMethod]
        public void ShouldNotBeEmptyAfterAddingProduct()
        {
            var cart = new Cart();
            cart.AddProduct(soap);
            Assert.IsFalse(cart.IsEmpty());
        }

        [DataTestMethod]
        [DataRow(5)]
        [DataRow(1)]
        public void ShouldBeAbleToGetQuantityOfProductsAdded(int quanity)
        {
            var cart = new Cart();
            for (int i = 0; i < quanity; i++)
            {
                cart.AddProduct(soap);
            }
            Assert.AreEqual(quanity, cart.GetQuantity());
        }


        [DataTestMethod]
        [DataRow(5)]
        [DataRow(1)]
        public void ShouldReturnCartTotal(int quantity)
        {
            var cart = new Cart();
            for (int i = 0; i < quantity; i++)
            {
                cart.AddProduct(soap);
            }
            Assert.AreEqual(quantity * soap.UnitPrice, cart.GetTotal());
        }

        [TestMethod]
        public void ShouldBeAbleToAddMultipleProducts()
        {
            var cart = new Cart();

            cart.AddProduct(soap);
            cart.AddProduct(soap);
            cart.AddProduct(soap);
            cart.AddProduct(deo);
            cart.AddProduct(deo);

            Assert.AreEqual(5, cart.GetQuantity());
            Assert.AreEqual(290, cart.GetTotal());
        }

    }
}