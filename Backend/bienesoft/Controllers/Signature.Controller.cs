using bienesoft.Funcions;
using Bienesoft.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bienesoft.Controllers
{
    [Controller]
    [Route("/api[controller]")]
    public class signatureController : Controller
    {
        public GeneralFunction GeneralFunction;

        [HttpPost("CreateSignature")]
        public IActionResult Create(signatureModel Signature)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("GetSignature")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("GetsSignature")]
        public IActionResult Gets(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpPost("UpdateSignature")]
        public IActionResult Update(int Id, signatureModel Signature)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpDelete("DeleteSignature")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }

    }
}
