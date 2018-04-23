using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeLeavePortal.Startup))]
namespace EmployeeLeavePortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
