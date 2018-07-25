using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Construction.Startup))]
namespace Construction
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
