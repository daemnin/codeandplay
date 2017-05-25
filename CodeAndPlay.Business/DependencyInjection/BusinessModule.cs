using CodeAndPlay.Business.Contracts;
using CodeAndPlay.Business.Process;
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


            Kernel.Bind<IOrganizerProcess>().To<OrganizerProcess>();
            Kernel.Bind<ISponsorProcess>().To<SponsorProcess>();
        }
    }
}
