using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GuestBookMvc.Startup))]
namespace GuestBookMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
