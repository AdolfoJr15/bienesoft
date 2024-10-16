using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bienesoft.Models;
using bienesoft.Funcions;
<<<<<<< HEAD
using bienesoft.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using Bienesoft.Services;

namespace Bienesoft.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : Controller
    {
        public IConfiguration _Configuration { get; set; }
        public GeneralFunction GeneralFunction;
        private readonly DepartmentServices _DepartmentServices;

        public DepartmentController(IConfiguration configuration, DepartmentServices departmentServices)
        {
            _Configuration = configuration;
            _DepartmentServices = departmentServices;
            GeneralFunction = new GeneralFunction(_Configuration); // Inicializa según tu implementación
        }

        [HttpPost("CreateDepartment")]
        public IActionResult AddDepartment(Department department)
        {
            try
            {
                _DepartmentServices.AddDepartment(department);
                return Ok(new
                {
                    message = "Departamento creado con éxito"
                });
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.ToString());
=======

namespace Bienesoft.Controllers
{
    [Controller]
    [Route("/api[controller]")]
    public class departmentController : Controller
    {
        public GeneralFunction GeneralFunction;

        [HttpPost("CreateDepartment")]
        public IActionResult Create(departmentModel Department)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.Message);
>>>>>>> 17e9e0a81495cdc9d950dce501677a7197442b84
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("GetDepartment")]
<<<<<<< HEAD
        public IActionResult GetDepartment(int id)
        {
            try
            {
                var department = _DepartmentServices.GetById(id);
                if (department == null)
                {
                    return NotFound("No se encontró el departamento");
                }
                return Ok(department);
=======
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

        [HttpGet("GetsDepartment")]
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

        [HttpPost("UpdateDepartment")]
        public IActionResult Update(int Id, departmentModel Department)
        {
            try
            {
                return Ok();
>>>>>>> 17e9e0a81495cdc9d950dce501677a7197442b84
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpDelete("DeleteDepartment")]
        public IActionResult Delete(int id)
        {
            try
            {
<<<<<<< HEAD
                var department = _DepartmentServices.GetById(id);
                if (department == null)
                {
                    return NotFound("El departamento con el ID " + id + " no se pudo encontrar");
                }
                _DepartmentServices.Delete(id);
                return Ok("Departamento eliminado con éxito");
            }
            catch (KeyNotFoundException knFEx)
            {
                return NotFound(knFEx.Message);
=======
                return Ok();
>>>>>>> 17e9e0a81495cdc9d950dce501677a7197442b84
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }

<<<<<<< HEAD
        [HttpGet("AllDepartments")]
        public ActionResult<IEnumerable<Department>> GetDepartments()
        {
            return Ok(_DepartmentServices.GetDepartments());
        }

        [HttpPut("UpdateDepartment")]
        public IActionResult Update(Department department)
        {
            if (department == null)
            {
                return BadRequest("El modelo de departamento es nulo");
            }

            try
            {
                _DepartmentServices.UpdateDepartment(department);
                return Ok("Departamento actualizado exitosamente");
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
=======

>>>>>>> 17e9e0a81495cdc9d950dce501677a7197442b84
    }
}
