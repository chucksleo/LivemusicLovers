using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LivemusicLovers.Startup))]
namespace LivemusicLovers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
