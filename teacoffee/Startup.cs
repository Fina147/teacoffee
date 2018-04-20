using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(teacoffee.Startup))]
namespace teacoffee
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
