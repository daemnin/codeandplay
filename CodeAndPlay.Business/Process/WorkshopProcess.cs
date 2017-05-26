using CodeAndPlay.Business.Contracts;
using CodeAndPlay.Business.Process.Abstract;
using CodeAndPlay.Commons.Entities;
using CodeAndPlay.Data.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace CodeAndPlay.Business.Process
{
    public class WorkshopProcess : ProcessBase, IWorkshopProcess
    {
        public WorkshopProcess(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Workshop> Get()
        {
            return UnitOfWork.WorkshopRepository.GetAll(null, null, i => i.Students, i => i.Requirements).Select(e => new Workshop
            {
                Id = e.Id,
                Location = e.Location,
                Instructor = e.Instructor,
                Company = e.Company,
                GroupSize = e.GroupSize,
                Description = e.Description,
                End = e.End,
                Start = e.Start,
                Requirements = e.Requirements.Select(r => new Requirement
                {
                    Description = r.Description
                }),
                Duration = e.Duration,
                AvailableSlots = e.GroupSize - e.Students.Count
            });
        }
    }
}
