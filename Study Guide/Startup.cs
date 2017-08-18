using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Study_Guide.Startup))]
namespace Study_Guide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
