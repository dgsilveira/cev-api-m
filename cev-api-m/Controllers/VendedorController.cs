using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cev_api_m.Controllers
{
    [ApiController]
    [Route("vendedor")]
    public class VendedorController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {

            return Ok("oi");
        }
    }
}
