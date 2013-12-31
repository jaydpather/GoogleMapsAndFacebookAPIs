using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoogleAndFacebookAPIs.Startup))]
namespace GoogleAndFacebookAPIs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
