using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JF.Startup))]
namespace JF
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
