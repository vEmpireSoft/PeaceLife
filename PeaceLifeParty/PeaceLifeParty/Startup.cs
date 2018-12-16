using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PeaceLifeParty.Startup))]
namespace PeaceLifeParty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
