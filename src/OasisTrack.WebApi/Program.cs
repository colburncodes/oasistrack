using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using OasisTrack.Application.Services;
using OasisTrack.Core.Interfaces;
using OasisTrack.Infrastructure.Data;
using OasisTrack.Infrastructure.Data.Repositories;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Configure Serilog
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File(
            path: "logs/oasistrack-.txt", 
            rollingInterval: RollingInterval.Day,
            retainedFileCountLimit: 7, // keep 7 most recent log files.
            rollOnFileSizeLimit: true, // roll to a new file if the size limit is reached before day ends.
            fileSizeLimitBytes: 10 * 1024 * 1024 // set max file size to 10 MB. Adjust as value as needed.
        )
    .MinimumLevel.Information() // minimum log level to prevent excessive logging.
    .CreateLogger();

builder.Host.UseSerilog();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(doc =>
{
    doc.SwaggerDoc("v1", new OpenApiInfo());
});

// Register the repository
builder.Services.AddScoped<IRouteRepository, RouteRepository>();
builder.Services.AddScoped<IStoreRepository, StoreRepository>();
   
// Register the service
builder.Services.AddScoped<IRouteService, RouteService>();
builder.Services.AddScoped<IStoreService, StoreService>();


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));



var app = builder.Build();
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(doc => doc.SwaggerEndpoint("/swagger/v1/swagger.json", "OasisTrack API v1"));
}

app.UseHttpsRedirection();

app.Run();


