using Microsoft.AspNetCore.Mvc;

namespace TestPipeline.Controllers
{
    [ApiController]
    [Route("/transaction")]
    public class TransactionController : ControllerBase
    {

        [HttpGet]
        public ActionResult Get()
        {
            return Ok("TransactionController ok!");
        }
    }
}
