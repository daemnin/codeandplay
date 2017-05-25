using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(CodeAndPlay.API.Startup))]
namespace CodeAndPlay.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            //Ninject
            app.UseNinjectMiddleware(DependencyInjectionConfig.Register);

            //OAuth
            OAuthConfig.Register(app);

            //CORS
            app.UseCors(CorsOptions.AllowAll);

            //Web API
            WebApiConfig.Register(config);
            app.UseNinjectWebApi(config);
        }
    }
}