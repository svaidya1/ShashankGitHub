using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWorldShashank.Startup))]
namespace HelloWorldShashank
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
