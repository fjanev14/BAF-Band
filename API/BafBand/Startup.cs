using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BafBand.Startup))]
namespace BafBand
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
