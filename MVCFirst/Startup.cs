using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFirst.Startup))]
namespace MVCFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
