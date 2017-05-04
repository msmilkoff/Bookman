namespace Bookman.Web.App_Start
{
    using AutoMapper;
    using Bookman.Models;
    using Bookman.ViewModels.Books;
    using Bookman.ViewModels.Orders;

    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Book, AllBooksViewModel>();
                cfg.CreateMap<Book, BookDetailsViewModel>();
                cfg.CreateMap<OrderBookViewModel, Order>();
                cfg.CreateMap<Order, OrderViewModel>();
            });
        
        }
    }
}