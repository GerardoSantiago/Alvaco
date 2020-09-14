using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alvaco.Startup))]
namespace Alvaco
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
