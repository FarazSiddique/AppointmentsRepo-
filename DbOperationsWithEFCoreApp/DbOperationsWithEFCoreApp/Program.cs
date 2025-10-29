


using DbOperationsWithEFCoreApp.Application.Services;
using DbOperationsWithEFCoreApp.Core.Interfaces;
using DbOperationsWithEFCoreApp.Infrastructure.Data;
using DbOperationsWithEFCoreApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AppDb")));
// Add services to the container.



// Register services
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<DoctorService>();

builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddScoped<LocationService>();

builder.Services.AddScoped<IReasonRepository, ReasonRepository>();
builder.Services.AddScoped<ReasonService>();

builder.Services.AddScoped<ITimeSlotsRepository, TimeSlotsRepository>();
builder.Services.AddScoped<TimeSlotsService>();

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
