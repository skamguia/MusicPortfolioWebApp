using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicPortfolioApp.Startup))]
namespace MusicPortfolioApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
