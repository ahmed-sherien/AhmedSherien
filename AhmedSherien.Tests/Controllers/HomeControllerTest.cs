using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AhmedSherien;
using AhmedSherien.Controllers;

namespace AhmedSherien.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Ahmed Sherien", result.ViewBag.Title);
        }
    }
}
