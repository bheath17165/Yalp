using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yalp.Startup))]
namespace Yalp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
