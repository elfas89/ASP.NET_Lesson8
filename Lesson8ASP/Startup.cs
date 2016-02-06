using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson8ASP.Startup))]
namespace Lesson8ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
