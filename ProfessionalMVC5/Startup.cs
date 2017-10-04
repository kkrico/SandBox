using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProfessionalMVC5.Startup))]
namespace ProfessionalMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
