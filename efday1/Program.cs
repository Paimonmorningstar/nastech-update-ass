
using efday1.Data;
using efday1.Services;
using efday1.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IStdService, StdService>();
builder.Services.AddScoped<IStdRepository, StdRepository>();

builder.Services.AddDbContext<StdManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnString")));

builder.Services.AddControllers();
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
