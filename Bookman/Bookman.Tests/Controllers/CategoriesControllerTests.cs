namespace Bookman.Tests.Controllers
{
    using System.Web.Mvc;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Bookman.Services.Abstractions;
    using Bookman.Web.Controllers;

    using Moq;

    [TestClass]
    public class CategoriesControllerTests
    {
        private Mock<ICategoryService> serviceMock;

        [TestInitialize]
        public void InitTests()
        {
            this.serviceMock = new Mock<ICategoryService>();
        }

        [TestMethod]
        public void ReturnsAllViewResult()
        {
            var controller = new CategoriesController(this.serviceMock.Object);

            var result = (ViewResult)controller.All();

            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void ReturnsShowViewResult()
        {
            var controller = new CategoriesController(this.serviceMock.Object);

            var result = (ViewResult)controller.Show(It.IsAny<string>());

            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
