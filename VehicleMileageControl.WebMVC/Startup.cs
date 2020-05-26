using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VehicleMileageControl.WebMVC.Startup))]
namespace VehicleMileageControl.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
