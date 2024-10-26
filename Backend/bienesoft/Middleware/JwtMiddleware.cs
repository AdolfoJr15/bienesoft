using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bienesoft.Services; // Asegúrate de usar el servicio adecuado
using System;
using bienesoft.Funcions;
using Microsoft.AspNetCore.Authorization;

public class JwtMiddleware
{
    private readonly RequestDelegate _next;
    private readonly string _key;
    private readonly GeneralFunction _GeneralFunction;
    private readonly IConfiguration _configuration;


    public JwtMiddleware(RequestDelegate next, IConfiguration configuration)
    {
        _configuration = configuration;
        _next = next;
        _key = configuration.GetSection("JWT").GetValue<string>("keysecret");
        _GeneralFunction = new GeneralFunction(_configuration);
    }

    public async Task Invoke(HttpContext context, UserServices userService)
    {
        // Verificar si el endpoint permite acceso anónimo
        var endpoint = context.GetEndpoint();
        var allowAnonymous = endpoint?.Metadata
            .GetMetadata<IAllowAnonymous>() != null;

        // Si el endpoint permite acceso anónimo, no validamos el token
        if (!allowAnonymous)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
            {
                AttachUserToContext(context, userService, token);
            }
        }

        await _next(context);
    }

    private void AttachUserToContext(HttpContext context, UserServices userService, string token)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_key);
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;
            var userEmail = jwtToken.Claims.First(x => x.Type == "User").Value;

            // Adjuntar el usuario al contexto si la validación del token es correcta
            context.Items["User"] = userService.GetByEmailAsync(userEmail).Result;
        }
        catch (Exception ex)
        {
            _GeneralFunction.Addlog(ex.Message);
            context.Response.StatusCode = StatusCodes.Status401Unauthorized; // Establecer un código de estado de error
            context.Response.ContentType = "application/json";
            context.Response.WriteAsync("{\"error\": \"Token inválido o expirado\"}");
            // Puedes agregar aquí un registro de errores si es necesario
        }
    }
}

