using Microsoft.AspNetCore.Mvc;
using net_core.Models;

namespace net_core.Controllers
{
    [ApiController]
    [Route("api/characters")]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(knight);
        }
    }
}