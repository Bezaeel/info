using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(info.Startup))]
namespace info
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
