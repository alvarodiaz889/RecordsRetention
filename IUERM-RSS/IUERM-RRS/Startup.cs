using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IUERM_RRS.Startup))]
namespace IUERM_RRS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
