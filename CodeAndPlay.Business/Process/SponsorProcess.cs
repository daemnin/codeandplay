using CodeAndPlay.Business.Contracts;
using CodeAndPlay.Business.Process.Abstract;
using CodeAndPlay.Commons.Entities;
using CodeAndPlay.Data.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace CodeAndPlay.Business.Process
{
    public class SponsorProcess : ProcessBase, ISponsorProcess
    {
        public SponsorProcess(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Sponsor> Get()
        {
            return UnitOfWork.SponsorRepository.GetAll().Select(e => new Sponsor
            {
                Name = e.Name,
                LogoUrl = e.LogoUrl,
                SiteUrl = e.SiteUrl
            });
        }
    }
}
