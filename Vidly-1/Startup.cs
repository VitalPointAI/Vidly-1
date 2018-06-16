using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_1.Startup))]
namespace Vidly_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
