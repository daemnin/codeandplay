using CodeAndPlay.Business.Process;
using CodeAndPlay.Data.Contracts;
using System.Web.Http;

namespace CodeAndPlay.API.Controllers
{
    public class OrganizerController : ApiController
    {
        public IUnitOfWork unitOfWork;

        public OrganizerController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IHttpActionResult Get()
        {
            var process = new OrganizerProcess(unitOfWork);
            var result = process.Get();
            return Ok(result);
        }
    }
}
