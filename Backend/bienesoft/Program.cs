using bienesoft.Models;
using bienesoft.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Bienesoft.Models;
using Bienesoft.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Bienesoft API", Version = "v1" });

    // requerir autorización
    /*
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Ingrese el token en el formato: Bearer {token}",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
    */
});

// Configurar base de datos
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(8, 0, 23)))
);

// Configurar servicios
builder.Services.AddScoped<ApprenticeServices>();
builder.Services.AddScoped<FileServices>();
builder.Services.AddScoped<AreaServices>();
builder.Services.AddScoped<PermissionServices>();
builder.Services.AddScoped<AttendantServices>();
builder.Services.AddScoped<UserServices>();
builder.Services.AddScoped<ProgramServices>();
builder.Services.AddScoped<DepartmentServices>();
builder.Services.AddScoped<LocalityServices>();

// Configurar JWT
var key = Encoding.UTF8.GetBytes(builder.Configuration["JWT:keysecret"]);
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false,
        ClockSkew = TimeSpan.Zero
    };
    options.Events = new JwtBearerEvents
    {
        OnMessageReceived = context =>
        {
            if (string.IsNullOrEmpty(context.Request.Headers["Authorization"]))
            {
                context.NoResult();
                context.Response.StatusCode = 401;
                context.Response.ContentType = "application/json";
                return context.Response.WriteAsync("{\"error\": \"Token no proporcionado\"}");
            }
            return Task.CompletedTask;
        },
        OnAuthenticationFailed = context =>
        {
            context.NoResult();
            context.Response.StatusCode = 401;
            context.Response.ContentType = "application/json";
            return context.Response.WriteAsync("{\"error\": \"Token inválido o expirado\"}");
        },
        OnChallenge = context =>
        {
            context.HandleResponse();
            if (!context.Response.HasStarted)
            {
                context.Response.StatusCode = 401;
                context.Response.ContentType = "application/json";
                return context.Response.WriteAsync("{\"error\": \"No autorizado: falta token\"}");
            }
            return Task.CompletedTask;
        }
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting(); // Primero, establece el enrutamiento

app.UseAuthentication(); // Luego, aplica la autenticación
app.UseAuthorization();  // Después, aplica la autorización

// Si estás usando un middleware personalizado para JWT, colócalo después de UseAuthorization
app.UseMiddleware<JwtMiddleware>(); // Este debería ser opcional si el JWT ya se está manejando en UseAuthentication

app.MapControllers(); // Finalmente, mapea los controladores

app.Run();
