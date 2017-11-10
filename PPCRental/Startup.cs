using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PPCRental.Startup))]
namespace PPCRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
