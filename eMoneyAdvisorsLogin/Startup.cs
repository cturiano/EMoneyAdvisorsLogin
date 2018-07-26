using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eMoneyAdvisorsLogin.Startup))]
namespace eMoneyAdvisorsLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
