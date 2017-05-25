using System.Threading.Tasks;
using System.Web.Http;

namespace CodeAndPlay.Security.API.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class SecretController : ApiController
    {
        public async Task<IHttpActionResult> Get()
        {
            return Ok(await Task.FromResult(new { message = "Admin secret" }));
        }
    }
}
