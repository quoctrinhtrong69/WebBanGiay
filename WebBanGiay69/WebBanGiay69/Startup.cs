using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBanGiay69.Startup))]
namespace WebBanGiay69
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
