using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCandWCF.Startup))]
namespace MVCandWCF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
