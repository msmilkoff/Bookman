using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bookman.Web.Startup))]
namespace Bookman.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
