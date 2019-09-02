using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BasicCalculator.Startup))]

namespace BasicCalculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
