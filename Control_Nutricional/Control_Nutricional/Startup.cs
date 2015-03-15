using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Control_Nutricional.Startup))]
namespace Control_Nutricional
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
