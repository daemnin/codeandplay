using CodeAndPlay.Security.API.Providers;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Ninject;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(CodeAndPlay.Security.API.Startup))]
namespace CodeAndPlay.Security.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            IKernel kernel = DependencyInjectionConfig.CreateAndRegister(app);

            ConfiureOAuth(app, kernel);

            app.UseCors(CorsOptions.AllowAll);
            WebApiConfig.Register(config);
            app.UseNinjectWebApi(config);
        }

        private void ConfiureOAuth(IAppBuilder app, IKernel kernel)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/api/account/login"),
                Provider = new AuthorizationProvider(kernel),
                RefreshTokenProvider = new RefreshTokenProvider(kernel)
            };

            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}