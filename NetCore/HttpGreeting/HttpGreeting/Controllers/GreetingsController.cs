using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HttpGreeting.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingsController : ControllerBase
    {
        public GreetingsController()
        {
        }

        [HttpPost("{name}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult Greeting([FromRoute] string name)
        {
            return Ok(string.Concat("Hello ", name));
        }
    }
}