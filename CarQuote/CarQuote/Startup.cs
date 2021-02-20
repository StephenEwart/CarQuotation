using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarQuote.Startup))]
namespace CarQuote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
