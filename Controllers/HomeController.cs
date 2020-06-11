using Microsoft.AspNetCore.Mvc;

namespace TestPipeline.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public ActionResult Get()
        {
            return Ok("ok!");
        }
    }
}
