using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentWebApp.Startup))]
namespace StudentWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
