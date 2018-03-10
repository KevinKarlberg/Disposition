using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DispositionSite.Startup))]
namespace DispositionSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
