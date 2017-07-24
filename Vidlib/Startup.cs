using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidlib.Startup))]
namespace Vidlib
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
