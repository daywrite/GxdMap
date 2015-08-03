using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GxdMap.WebSite.Startup))]
namespace GxdMap.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
