using Microsoft.AspNetCore.Mvc;

namespace ReactGrud.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SchoolController : ControllerBase
    {
        [HttpGet(Name = "SchoolList")]
        public IActionResult Index()
        {
            var result = "";

            return null;
        }
    }
}
