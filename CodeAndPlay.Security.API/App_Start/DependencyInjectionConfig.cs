using CodeAndPlay.Security.Data.Repository;
using CodeAndPlay.Security.Model.Context;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.OwinHost;
using Owin;
using System.Reflection;

namespace CodeAndPlay.Security.API
{
    public class DependencyInjectionConfig
    {
        public static IKernel CreateAndRegister(IAppBuilder app)
        {
            IKernel kernel = CreateKernel();
            app.UseNinjectMiddleware(() => { return kernel; });
            return kernel;
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            RegisterServices(kernel);
            return kernel;
        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<SymposiumAuthContext>().To<SymposiumAuthContext>().InRequestScope();
            kernel.Bind<ISecurityRepository>().To<SecurityRepository>();
        }
    }
}