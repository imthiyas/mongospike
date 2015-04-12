using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mongoNotes.Startup))]
namespace mongoNotes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
