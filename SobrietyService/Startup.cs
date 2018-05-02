using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SobrietyService.Startup))]

namespace SobrietyService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}