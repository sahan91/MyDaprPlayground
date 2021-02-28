using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dapr.microservice.webapi.Controllers
{
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet("hello")]
        public ActionResult<string> Get()
        {
            return "Hello World!";
        }
    }
}