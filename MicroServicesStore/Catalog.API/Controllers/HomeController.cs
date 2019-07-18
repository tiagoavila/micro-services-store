using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Content("Welcome to catalog API");
        }
    }
}
