using bienesoft.Funcions;
using bienesoft.Models;
using bienesoft.Services;
using Bienesoft.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bienesoft.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ApprenticeController : Controller
    {
        public IConfiguration _Configuration { get; set; }
        public GeneralFunction GeneralFunction;
        private readonly ApprenticeServices _ApprenticeServices;

        public ApprenticeController(IConfiguration configuration, ApprenticeServices apprenticeServices)
        {
            _Configuration = configuration;
            _ApprenticeServices = apprenticeServices;
        }

        [HttpPost("Create")]
        public IActionResult AddApprendice(Apprentice apprentice)
        {
            try
            {
                _ApprenticeServices.AddApprendice(apprentice);
                return Ok(new
                {
                    message = "Apprentice creado con exito"
                });
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.ToString());
                return StatusCode(500, ex.ToString());
            }

        }

        [HttpGet("AllApprentice")]
        public ActionResult<IEnumerable<Apprentice>> AllApprentice()
        {
            return Ok(_ApprenticeServices.AllApprentice());
        }

        [HttpGet("GetApprentice")]
        public IActionResult GetApprentice(int id)
        {
            try
            {
                var apprentice = _ApprenticeServices.GetById(id);
                if (apprentice == null)
                {
                    return NotFound("No Se Encontró El Aprendiz");
                }
                return Ok(apprentice);
            }
            catch (Exception ex)
            {

                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());

            }
        }
        [HttpPost("UpdateApprentice")]
        public IActionResult Update(int Id, Apprentice Aprendiz)
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
        [HttpDelete("DeleteApprentice")]
        public IActionResult Delete(int id)
        {
            try
            {
                var apprentice = _ApprenticeServices.GetById(id);
                if (apprentice == null)
                {
                    return NotFound("El Aprendiz Con El Id" + id + "No Se Pudo Encontrar");
                }
                _ApprenticeServices.Delete(id);
                return Ok("Apprendice Eliminado Con Exito");
            }
            catch (KeyNotFoundException knFEx)
            {
                return NotFound(knFEx.Message);
            }
            catch (Exception ex) 
            {
                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpPut("UpdateApprentice")]
        public IActionResult Update(Apprentice apprentice)
        {
            if (apprentice == null)
            {
                return BadRequest("El modelo de Apprentice es nulo");
            }

            try
            {
                _ApprenticeServices.UpdateApprentice(apprentice);
                return Ok("Apprentice actualizado exitosamente");
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());

            }
        }



    }
}
