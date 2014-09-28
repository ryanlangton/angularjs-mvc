using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullSPA.Startup))]
namespace FullSPA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
