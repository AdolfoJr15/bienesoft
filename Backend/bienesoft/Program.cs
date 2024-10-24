using bienesoft.Models;
using bienesoft.Services;
using Bienesoft.Models;
using Bienesoft.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version (8,0,23)))
);

builder.Services.AddScoped<ApprenticeServices>();

builder.Services.AddScoped<FileServices>();

builder.Services.AddScoped<AreaServices>();

builder.Services.AddScoped<PermissionServices>();

builder.Services.AddScoped<AttendantServices>();

builder.Services.AddScoped<UserServices>();
builder.Services.AddScoped<ProgramServices>();
builder.Services.AddScoped<DepartmentServices>();
builder.Services.AddScoped<LocalityServices>();
builder.Services.AddScoped<ResponsibleServices>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();