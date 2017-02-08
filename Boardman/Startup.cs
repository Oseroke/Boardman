using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Boardman.Startup))]
namespace Boardman
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
