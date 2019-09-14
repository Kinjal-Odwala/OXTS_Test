using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OXTS_Test.Startup))]
namespace OXTS_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
