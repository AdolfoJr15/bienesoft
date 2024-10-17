<<<<<<< HEAD
﻿//using bienesoft.Funcions;
//using bienesoft.Models;
//using bienesoft.Services;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace bienesoft.Controllers
//{
//    [ApiController]
//    [Route("Api/[controller]")]
//    public class ProgramController : Controller
//    {
//        public IConfiguration _Configuration { get; set; }
//        public GeneralFunction GeneralFunction;
//        private readonly ProgramServices _ProgramServices;

//        public ProgramController(IConfiguration configuration, ProgramServices programServices)
//        {
//            _Configuration = configuration;
//            _ProgramServices = programServices;
//        }

//        [HttpPost("CreateProgram")]
//        public IActionResult AddProgram(Program program)
//        {
//            try
//            {
//                _ProgramServices.AddProgram(program);
//                return Ok(new
//                {
//                    message = "Program creado con exito"
//                });
//            }
//            catch (Exception ex)
//            {
//                GeneralFunction.Addlog(ex.ToString());
//                return StatusCode(500, ex.ToString());
//            }

//        }

//        [HttpGet("GetProgram")]

//        public IActionResult Get(int id)
//        {
//            try
//            {
//                return Ok();
//            }
//            catch (Exception ex)
//            {

//                GeneralFunction.Addlog(ex.Message);
//                return StatusCode(500, ex.ToString());

//            }
//        }
//        [HttpGet("GetsProgram")]
//        public IActionResult Gets(int id)
//        {
//            try
//            {
//                return Ok();
//            }
//            catch (Exception ex)
//            {

//                GeneralFunction.Addlog(ex.Message);
//                return StatusCode(500, ex.ToString());

//            }
//        }
//        [HttpPost("UpdateProgram")]
//        public IActionResult Update(int Id,Program program)
//        {
//            try
//            {
//                return Ok();
//            }
//            catch (Exception ex)
//            {
//                GeneralFunction.Addlog(ex.Message);
//                return StatusCode(500, ex.ToString());
//            }
//        }
//        [HttpDelete("DeleteProgram")]
//        public IActionResult Delete(int id)
//        {
//            try
//            {
//                return Ok();
//            }
//            catch (Exception ex)
//            {
//                GeneralFunction.Addlog(ex.Message);
//                return StatusCode(500, ex.ToString());
//            }
//        }
//        [HttpGet("AllProgram")]
//        public ActionResult<IEnumerable<Program>> GetProgram()
//        {
//            return Ok(_ProgramServices.GetProgram());
//        }



//    }
//}
=======
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bienesoft.Models;
using bienesoft.Funcions;
using bienesoft.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using Bienesoft.Services;

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
            GeneralFunction = new GeneralFunction(_Configuration); // Inicializa según tu implementación
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
        public ActionResult<IEnumerable<ProgramModel>> GetPrograms()
        {
            return Ok(_ProgramServices.GetPrograms());
        }

        [HttpPut("UpdateProgram")]
        public IActionResult Update(ProgramModel program)
        {
            if (program == null)
            {
                return BadRequest("El modelo de programa es nulo");
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
    }
}
>>>>>>> 64461c392736522cbfe87334807d176ce0a35131
