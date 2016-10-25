using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nalasa.DetentionCalculator.Startup))]
namespace Nalasa.DetentionCalculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
