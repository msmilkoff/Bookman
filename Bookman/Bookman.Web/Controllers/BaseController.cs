namespace Bookman.Web.Controllers
{
    using System.Web.Mvc;
    using Bookman.Services.Abstractions;

    public abstract class BaseController : Controller
    {
        public BaseController(IHomeService homeservice)
        {
            this.HomeService = homeservice;
        }

        protected IHomeService HomeService { get; set; }
    }
}