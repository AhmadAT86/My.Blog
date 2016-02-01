using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(My.Blog.Web.Startup))]
namespace My.Blog.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //inga förändringar utan bara testar uppkopplingen mot github
            ConfigureAuth(app);
        }
    }
}
