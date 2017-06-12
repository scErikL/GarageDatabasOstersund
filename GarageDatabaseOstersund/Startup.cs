using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GarageDatabaseOstersund.Startup))]
namespace GarageDatabaseOstersund
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
