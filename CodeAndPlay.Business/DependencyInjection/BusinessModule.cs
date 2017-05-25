using CodeAndPlay.Data;
using CodeAndPlay.Data.Contracts;
using CodeAndPlay.Model.Context;
using Ninject.Modules;
using Ninject.Web.Common;

namespace CodeAndPlay.Business.DependencyInjection
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<SymposiumContext>().ToSelf().InRequestScope();
            Kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
