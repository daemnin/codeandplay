using CodeAndPlay.Business.Contracts;
using CodeAndPlay.Business.Process.Abstract;
using CodeAndPlay.Commons.Entities;
using CodeAndPlay.Data.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace CodeAndPlay.Business.Process
{
    public class OrganizerProcess : ProcessBase, IOrganizerProcess
    {
        public OrganizerProcess(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Organizer> Get()
        {
            return UnitOfWork.OrganizerRepository.GetAll(includes: r => r.Roles).Select(e => new Organizer
            {
                Name = e.Name,
                Roles = e.Roles.Select(r => new Role
                {
                    Name = r.Description
                })
            });
        }
    }
}