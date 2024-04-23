using Microsoft.AspNetCore.Mvc;

namespace _20240422.Controllers
{
    [Route("api/ejemplo1")]
    public class Ejemplo1Controller : Controller
    {
        [HttpGet("prueba1")]
        public async Task<IActionResult> prueba1()
        {
            try {
                // ...
                return Ok("Esta es una prueba");
            } catch (Exception e){
                return BadRequest();
            }
        }
        [HttpGet("prueba2")]
        [Produces("text/html")]
        public async Task<IActionResult> prueba2()
        {
            try
            {
                // ...
                return Ok("<h2><b><i>Esta es otra prueba</i></b></h2>");
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("prueba3/{val}")]
        public async Task<IActionResult> prueba3(string val) {
            try
            {
                // ...
                return Ok("Buenas noches " + val);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("prueba3/{val}/edad/{num}")]
        public async Task<IActionResult> prueba4(string val, int num)
        {
            try
            {
                // ...
                return Ok($"Buenas noches {val}, veo que tienes {num} anyos.");
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
