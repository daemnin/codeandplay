using CodeAndPlay.Business.Contracts;
using Ninject;
using System;
using System.Web.Http;

namespace CodeAndPlay.API.Controllers
{
    public class WorkshopController : ApiController
    {
        private IKernel kernel;

        public WorkshopController(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public IHttpActionResult Get()
        {
            try
            {
                var process = kernel.Get<IWorkshopProcess>();
                var result = process.Get();

                return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
