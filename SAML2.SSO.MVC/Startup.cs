using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAML2.SSO.MVC.Startup))]
namespace SAML2.SSO.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
