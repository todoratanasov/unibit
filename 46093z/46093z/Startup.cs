using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_46093z.Startup))]
namespace _46093z
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
