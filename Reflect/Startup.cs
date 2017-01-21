using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Reflect.Startup))]
namespace Reflect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
