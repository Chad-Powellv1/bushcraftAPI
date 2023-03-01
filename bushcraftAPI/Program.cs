using bushcraftAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog.Core;
using Serilog;

IConfigurationRoot configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

Logger logger = new LoggerConfiguration()
    .ReadFrom.Configuration(configuration)
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Add database context
builder.Services.AddDbContext<BlogContext>(options =>
    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// Add logging
builder.Services.AddLogging(logging =>
{
    logging.ClearProviders();
    logging.AddSerilog(logger);

});
builder.Services.AddSwaggerGen(config =>
{ 
    config.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Central KY Bushcraft API",
        Version = "v1.0.1.2",
        Description = "A simple example ASP.NET Core Web API for Central KY Bushcraft blog",
        Contact = new OpenApiContact
        {
            Name = "Chad Powell",
            Email = "chada.powell@outlook.com",
            Url = new Uri("https://www.linkedin.com/in/chad-powell-dev/"),
        },
    });
});
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