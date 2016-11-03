using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Battleship.Startup))]
namespace Battleship
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
