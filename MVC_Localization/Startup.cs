using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Localization.Startup))]
namespace MVC_Localization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
