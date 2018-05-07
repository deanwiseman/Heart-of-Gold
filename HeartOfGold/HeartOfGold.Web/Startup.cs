using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HeartOfGold.Web.Startup))]
namespace HeartOfGold.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
