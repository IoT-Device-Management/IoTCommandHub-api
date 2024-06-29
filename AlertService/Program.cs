using Microsoft.EntityFrameworkCore;
using AlertService.Helpers;
using IotCommandHubEFLibrary.DataAcess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AlertDataContext>(options => options
       .UseNpgsql(SecretsHelper.GetDatabaseConnectionString(builder)) 
       .UseSnakeCaseNamingConvention());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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