using Microsoft.AspNetCore.Mvc;

namespace bienesoft.Controllers
{
    [Controller]
    [Route("/api[controller]")]
    public class Locality : Controller
    {
        [HttpPost]
        public IActionResult Create(Locality locality)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }
        [HttpGet("GetLocality")]
        public IActionResult create()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }
        [HttpPost("UpdateLocality")]

        public IActionResult Update()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }

        }
        [HttpDelete("DeleteLocality")]
        public IActionResult Delete()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }

        }
    }
}
