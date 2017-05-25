using CodeAndPlay.Business.Contracts;
using Ninject;
using System;
using System.Web.Http;

namespace CodeAndPlay.API.Controllers
{
    public class SponsorController : ApiController
    {
        public IKernel kernel;

        public SponsorController(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public IHttpActionResult Get()
        {
            try
            {
                var process = kernel.Get<ISponsorProcess>();
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