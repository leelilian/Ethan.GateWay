using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ethan.GateWay.WebApp.Startup))]
namespace Ethan.GateWay.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
