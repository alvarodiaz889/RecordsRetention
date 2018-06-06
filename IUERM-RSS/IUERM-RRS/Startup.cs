using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartupAttribute(typeof(IUERM_RRS.Startup))]
namespace IUERM_RRS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                CookieSecure = CookieSecureOption.Always,
                ExpireTimeSpan = System.TimeSpan.FromMinutes(30),
                LoginPath = new PathString("/Account/Login"),
                LogoutPath = new PathString("/Account/LogOff")
            });
        }
    }
}
