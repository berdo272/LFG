using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LFG.Startup))]
namespace LFG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
