using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Labb4._4Web.Startup))]
namespace Labb4._4Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
