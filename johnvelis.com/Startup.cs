using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(johnvelis.com.Startup))]
namespace johnvelis.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
