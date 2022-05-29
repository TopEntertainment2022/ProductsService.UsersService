using Microsoft.EntityFrameworkCore;
using TopEntertainment.AccessData;
using TopEntertainment.AccessData.Commands;
using TopEntertainment.Application.Services;
using TopEntertainment.Domain.Commands;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TopEntertainmentDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddTransient<IUsuarioRepository, UsuariosRepository>();
builder.Services.AddTransient<IUsuarioService, UsuarioServices>();
builder.Services.AddTransient<IOpinionRepository, OpinionRepository>();
builder.Services.AddTransient<IOpinionService, OpinionServices>();


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
