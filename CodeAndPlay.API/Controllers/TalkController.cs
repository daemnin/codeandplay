using CodeAndPlay.Business.Contracts;
using Ninject;
using System;
using System.Web.Http;

namespace CodeAndPlay.API.Controllers
{
    public class TalkController : ApiController
    {
        private IKernel kernel;

        public TalkController(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public IHttpActionResult Get()
        {
            try
            {
                var process = kernel.Get<ITalkProcess>();
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
