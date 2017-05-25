using CodeAndPlay.Business.DependencyInjection;
using Ninject;
using System.Reflection;

namespace CodeAndPlay.API
{
    public class DependencyInjectionConfig
    {
        public static IKernel Register()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            RegisterServices(kernel);
            return kernel;
        }

        private static void RegisterServices(StandardKernel kernel)
        {
            kernel.Load<BusinessModule>();
        }
    }
}