namespace Bookman.Web.App_Start
{
    using AutoMapper;
    using Bookman.Models;
    using Bookman.ViewModels.Categories;
    using ViewModels.Home;

    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Book, LatestBookViewModel>());
            
        }
    }
}