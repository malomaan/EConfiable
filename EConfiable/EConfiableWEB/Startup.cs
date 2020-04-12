using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EConfiableWEB.Startup))]
namespace EConfiableWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
