namespace Bookman.Services.OrderServices
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Bookman.Data;
    using Bookman.Models;
    using Bookman.Services.Abstractions;
    using Bookman.ViewModels.Orders;

    public class OrderService : BaseService, IOrderService
    {
        public OrderService(IBookmanData data)
            : base(data)
        {
        }

        public OrderBookViewModel GetOrderedBook(int bookId, string bookTitle)
        {
            var book = this.Data.Books
                .All()
                .First(b => b.Id == bookId);
            var viewModel = new OrderBookViewModel
            {
                Book = book
            };

            return viewModel;
        }

        public Order CreateOrder(OrderBookViewModel viewModel)
        {
            var order = Mapper.Map<OrderBookViewModel, Order>(viewModel);
            return order;
        }

        public void PersistOrder(Order order, string userId)
        {
            this.Data.Orders.Add(order);
            var user = this.Data.Users.GetById(userId);
            user.Orders.Add(order);

            this.Data.SaveChanges();
        }

        public IEnumerable<OrderViewModel> GetUserOrders(string userId)
        {
            var orders = this.Data.Orders
                .All()
                .Where(o => o.UserId == userId)
                .ToList();

            var viewModel = Mapper.Map<IEnumerable<Order>, IEnumerable<OrderViewModel>>(orders);
            return viewModel;
        }
    }
}
