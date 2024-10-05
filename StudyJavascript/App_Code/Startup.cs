using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudyJavascript.Startup))]
namespace StudyJavascript
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
