using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRIS_3_Nav_Material.Startup))]
namespace CRIS_3_Nav_Material
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
