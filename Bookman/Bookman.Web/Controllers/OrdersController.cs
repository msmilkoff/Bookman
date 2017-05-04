namespace Bookman.Web.Controllers
{
    using System.Web.Mvc;
    using System.Web.Mvc.Expressions;
    using Bookman.Common;
    using Bookman.Services.Abstractions;
    using Bookman.ViewModels.Orders;
    using Microsoft.AspNet.Identity;

    public class OrdersController : Controller
    {
        private IOrderService orderService;

        public OrdersController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet]
        [Route("Orders/Buy/{bookId}/{bookTitle}")]
        [Authorize]
        public ActionResult Buy(int bookId, string bookTitle)
        {
            var viewModel = this.orderService.GetOrderedBook(bookId, bookTitle);

            return View(viewModel);
        }

        [HttpPost]
        [Route("Orders/Buy/{bookId}/{bookTitle}")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Buy(OrderBookViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                this.Redirect($"Books/Details/{viewModel.BookId}/{viewModel.Book.Title}");
            }

            var order = this.orderService.CreateOrder(viewModel);

            var userId = this.User.Identity.GetUserId();
            order.UserId = userId;

            this.orderService.PersistOrder(order, userId);

            return this.RedirectToAction<OrdersController>(c => c.MyOrders());
        }

        [HttpGet]
        [Route("Orders/MyOrders")]
        [Authorize]
        public ActionResult MyOrders()
        {
            if (!this.User.IsInRole(GlobalConstants.UserRole))
            {
                this.RedirectToAction<HomeController>(c => c.Index());
            }

            var viewModel = this.orderService.GetUserOrders(this.User.Identity.GetUserId());
            return View(viewModel);
        }
    }
}