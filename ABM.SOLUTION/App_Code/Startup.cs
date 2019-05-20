using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ABM.SOLUTION.Startup))]
namespace ABM.SOLUTION
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
