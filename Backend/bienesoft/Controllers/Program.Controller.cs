using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bienesoft.Models;
using bienesoft.Funcions;
using bienesoft.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace Bienesoft.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProgramController : Controller
    {
        public IConfiguration _Configuration { get; set; }
        public GeneralFunction GeneralFunction;
        private readonly ProgramServices _ProgramServices;

        public ProgramController(IConfiguration configuration, ProgramServices programServices)
        {
            _Configuration = configuration;
            _ProgramServices = programServices;
            GeneralFunction = new GeneralFunction(_Configuration); // Asegúrate de inicializar GeneralFunction si es necesario.
        }

        [HttpPost("CreateProgram")]
        public IActionResult AddProgram(ProgramModel program)
        {
            try
            {
                _ProgramServices.AddProgram(program);
                return Ok(new
                {
                    message = "Programa creado con éxito"
                });
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.ToString());
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("GetProgram")]
        public IActionResult GetProgram(int id)
        {
            try
            {
                var program = _ProgramServices.GetById(id);
                if (program == null)
                {
                    return NotFound("No se encontró el programa");
                }
                return Ok(program);
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpPut("UpdateProgram")]
        public IActionResult UpdateProgram(int id, ProgramModel program)
        {
            if (program == null || id != program.Program_Id)
            {
                return BadRequest("El modelo de Programa es nulo o el ID no coincide");
            }

            try
            {
                _ProgramServices.UpdateProgram(program);
                return Ok("Programa actualizado exitosamente");
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

        [HttpDelete("DeleteProgram")]
        public IActionResult Delete(int id)
        {
            try
            {
                var program = _ProgramServices.GetById(id);
                if (program == null)
                {
                    return NotFound("El programa con el ID " + id + " no se pudo encontrar");
                }
                _ProgramServices.Delete(id);
                return Ok("Programa eliminado con éxito");
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

        [HttpGet("AllPrograms")]
        public ActionResult<IEnumerable<ProgramModel>> GetAllPrograms()
        {
            return Ok(_ProgramServices.GetPrograms());
        }
    }
}