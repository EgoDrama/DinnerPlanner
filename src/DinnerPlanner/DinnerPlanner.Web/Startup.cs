using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DinnerPlanner.Web.Startup))]
namespace DinnerPlanner.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
