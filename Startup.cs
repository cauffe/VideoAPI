using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoAPI.Startup))]
namespace VideoAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
