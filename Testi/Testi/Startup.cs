using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testi.Startup))]
namespace Testi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
