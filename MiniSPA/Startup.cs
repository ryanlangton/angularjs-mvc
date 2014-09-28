using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiniSPA.Startup))]
namespace MiniSPA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
