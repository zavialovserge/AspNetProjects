using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestDS.WebUI.Startup))]
namespace TestDS.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
