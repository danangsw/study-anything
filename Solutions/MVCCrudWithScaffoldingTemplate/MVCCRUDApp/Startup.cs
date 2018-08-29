using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCCRUDApp.Startup))]
namespace MVCCRUDApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
