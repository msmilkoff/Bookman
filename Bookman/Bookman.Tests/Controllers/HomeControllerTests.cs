namespace Bookman.Tests.Controllers
{
    using System.Web.Mvc;
    using Bookman.Services.Abstractions;
    using Bookman.Web.Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void ReturnsIndexView()
        {
            var homeServiceMock = new Mock<IHomeService>();
            var newsServiceMock = new Mock<INewsService>();

            var controller = new HomeController(homeServiceMock.Object, newsServiceMock.Object);
            var result = (ViewResult)controller.Index();

            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
