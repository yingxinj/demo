using Demo.Web;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace Demo.Web
{
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app) {}
    }
}
