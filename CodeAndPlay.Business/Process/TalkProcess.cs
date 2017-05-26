using CodeAndPlay.Business.Contracts;
using CodeAndPlay.Business.Process.Abstract;
using CodeAndPlay.Commons.Entities;
using CodeAndPlay.Data.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace CodeAndPlay.Business.Process
{
    public class TalkProcess : ProcessBase, ITalkProcess
    {
        public TalkProcess(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Talk> Get()
        {
            return UnitOfWork.TalkRepository.GetAll().Select(e => new Talk
            {
                Title = e.Title,
                Company = e.Company,
                Speaker = e.Speaker,
                Date = e.Date,
                Duration = e.Duration
            });
        }
    }
}
