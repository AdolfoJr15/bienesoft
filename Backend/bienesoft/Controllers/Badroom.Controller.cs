using Bienesoft.Models;
using Microsoft.AspNetCore.Mvc;

namespace bienesoft.Controllers
{
    [Controller]
    [Route("/api[controller]")]
    public class Badroom : Controller
    {
        [HttpPost]
        public IActionResult Create(Badroom badroom)
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
        [HttpGet("GetBadroom")]
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
        [HttpPost("UpdateBadroom")]

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
        [HttpDelete("DeleteBadroom")]
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
