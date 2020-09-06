using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ak841515_MIS4200.Startup))]
namespace ak841515_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
