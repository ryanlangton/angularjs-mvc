using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiniSPARouting.Startup))]
namespace MiniSPARouting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
