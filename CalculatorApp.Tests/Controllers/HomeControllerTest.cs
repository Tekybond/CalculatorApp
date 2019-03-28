using CalculatorApp.Controllers;
using CalculatorApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace CalculatorApp.Tests.Controllers
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
        }

        [TestMethod]
        public void TestPostMethodFailed()
        {
            var modelRingColor = new RingColorModel() { BandAColor = "", BandBColor = "OG", BandCColor = "RD", BandDColor = "GN" };
            // Arrange
            HomeController controller = new HomeController();

            var result = controller.Index(modelRingColor) as JsonResult;
            var data = result.Data as ResultModel;

            Assert.IsNotNull(data);
            Assert.IsTrue(data.IsError);
        }


    }
}
