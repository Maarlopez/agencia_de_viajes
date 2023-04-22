using Application.Interfaces;
using Application.UseCase.Tarjetas;
using Application.UseCase.Usuarios;
using Infrastructure.Command;
using Infrastructure.Persistence;
using Infrastructure.Query;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Custom
var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<AgenciaViajesContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IUsuarioCommand, UsuarioCommand>();
builder.Services.AddScoped<IUsuarioQuery, UsuarioQuery>();

builder.Services.AddScoped<ITarjetaService, TarjetaService>();
builder.Services.AddScoped<ITarjetaCommand, TarjetaCommand>();
builder.Services.AddScoped<ITarjetaQuery, TarjetaQuery>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
