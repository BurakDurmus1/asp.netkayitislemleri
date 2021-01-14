using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssigmentDeneme.Startup))]
namespace AssigmentDeneme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
