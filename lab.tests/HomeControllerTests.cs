using Microsoft.AspNetCore.Mvc;

namespace lab.tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void GetIndex()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual(null, result.ViewName);
        }

        [TestMethod]
        public void GetBuy()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Buy(1) as ViewResult;

            // Assert
            Assert.AreEqual(null, result.ViewName);
        }

        [TestMethod]
        public void PostBuy()
        {
            // Arrange
            HomeController controller = new HomeController();

            var Object = ObjectPurchase();
            // Act
            string result = controller.Buy(Object);

            // Assert
            Assert.AreEqual("Спасибо за покупку, Дмитрий!", result);
        }

        [TestMethod]
        public void PostIndex()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index(1) as ViewResult;
            // Assert
            Assert.AreEqual(null, result.ViewName);
        }

        private Purchase ObjectPurchase()
        {
            Purchase purchase = new()
            {
                ProductID = 1,
                Person = "Дмитрий",
                Address = "Волгоград"
            };
            return purchase;
        }
    }
}