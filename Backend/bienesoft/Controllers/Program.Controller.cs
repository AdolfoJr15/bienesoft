//using bienesoft.Funcions;
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
