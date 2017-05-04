namespace Bookman.Services.Abstractions
{
    using System.Collections.Generic;
    using Bookman.Models;
    using Bookman.ViewModels.Orders;

    public interface IOrderService
    {
        OrderBookViewModel GetOrderedBook(int bookId, string bookTitle);

        Order CreateOrder(OrderBookViewModel viewModel);

        void PersistOrder(Order order, string userId);

        IEnumerable<OrderViewModel> GetUserOrders(string userId);
    }
}
