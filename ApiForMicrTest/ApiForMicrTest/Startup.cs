using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApiForMicrTest.Startup))]
namespace ApiForMicrTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
