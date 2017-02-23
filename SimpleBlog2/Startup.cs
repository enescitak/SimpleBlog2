using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleBlog2.Startup))]
namespace SimpleBlog2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
