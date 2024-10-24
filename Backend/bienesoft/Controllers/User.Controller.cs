using bienesoft.Funcions;
using bienesoft.models;
using bienesoft.Models;
using bienesoft.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace bienesoft.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly JWTModels _jwtSettings;
        private readonly UserServices _UserServices;
        public GeneralFunction GeneralFunction;

        public UserController(IConfiguration configuration, UserServices userServices)
        {
            _configuration = configuration;
            _jwtSettings = configuration.GetSection("JWT").Get<JWTModels>();
            _UserServices = userServices;
            GeneralFunction = new GeneralFunction(_configuration); // Inicializa GeneralFunction aquí
        }

        [HttpPost("Login")]
        public IActionResult Create(User user)
        {
            try
            {
                var key = Encoding.UTF8.GetBytes(_jwtSettings.keysecret);
                ClaimsIdentity subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("User", user.Email)
                });

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = subject,
                    Expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_jwtSettings.JWTExpireTime)),
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256Signature
                    )
                };

                var token = new JwtSecurityTokenHandler().CreateToken(tokenDescriptor);
                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.ToString());
                return StatusCode(500, "Ocurrió un error en el servidor.");
            }
        }

        // Método para restablecer la contraseña
    [HttpPost("ResetPassUser")]
    public async Task<IActionResult> ResetPassword(ResetPassUser user)
    {
    try
    {
        // Verificar si el correo existe en la base de datos
        var userExists = await _UserServices.UserExistsByEmail(user.Email);
        
        if (!userExists)
        {
            return NotFound("El correo electrónico no está registrado.");
        }

        // Si el correo existe, enviar el correo
        var emailResponse = await GeneralFunction.SendEmail(user.Email);

        if (!emailResponse.Status)
        {
            return BadRequest(emailResponse.Message);
        }

        return Ok("Correo de restablecimiento de contraseña enviado correctamente.");
    }
    catch (Exception ex)
    {
        GeneralFunction.Addlog(ex.ToString());
        return StatusCode(500, ex.ToString());
    }
    }


        [HttpPost("CreateUser")]
        public IActionResult AddUser(User user)
        {
            try
            {
                var error = GeneralFunction.ValidModel(user);
                if (error.Length == 0)
                {
                    _UserServices.AddUser(user);
                    return Ok(new { message = "Usuario creado con éxito" });
                }
                return BadRequest(error);
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.ToString());
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("AllUsers")]
        public ActionResult<IEnumerable<User>> AllUsers()
        {
            return Ok(_UserServices.AllUser());
        }

        [HttpGet("GetUser/{id}")]
        public IActionResult GetUser(int id)
        {
            try
            {
                var user = _UserServices.GetById(id);
                if (user == null)
                {
                    return NotFound("No se encontró el usuario");
                }
                return Ok(user);
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpDelete("DeleteUser/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var userToDelete = _UserServices.GetById(id);
                if (userToDelete == null)
                {
                    return NotFound($"El usuario con el ID {id} no se pudo encontrar");
                }

                _UserServices.Delete(id);
                return Ok("Usuario eliminado con éxito");
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

        [HttpPut("UpdateUser")]
        public IActionResult Update(User user)
        {
            if (user == null)
            {
                return BadRequest("El modelo de usuario es nulo");
            }

            try
            {
                _UserServices.UpdateUser(user);
                return Ok("Usuario actualizado exitosamente");
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

        [HttpGet("AllUsersInRange")]
        public ActionResult<IEnumerable<User>> GetAllInRange(int inicio, int fin)
        {
            try
            {
                // Validar los parámetros.
                if (inicio < 1 || fin < inicio)
                {
                    return BadRequest("Los parámetros de rango son inválidos.");
                }

                var usersInRange = _UserServices.AllUser()
                    .Skip(inicio - 1)
                    .Take(fin - inicio + 1)
                    .ToList();

                if (!usersInRange.Any())
                {
                    return NotFound("No se encontraron usuarios en el rango especificado.");
                }

                return Ok(usersInRange);
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }
    }
}