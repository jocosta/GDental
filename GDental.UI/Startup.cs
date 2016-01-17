using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GDental.UI.Startup))]
namespace GDental.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
