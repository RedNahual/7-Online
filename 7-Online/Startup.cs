using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_7_Online.Startup))]
namespace _7_Online
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
