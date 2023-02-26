using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Reflection;
using UniveraStoreCase.Business.Services.ProductServices;
using UniveraStoreCase.DataAccess.Data;
using UniveraStoreCase.DataAccess.Repositories.EfCoreRepositories;
using UniveraStoreCase.DataAccess.Repositories.IRepositories;
using UniveraStoreCase.DataAccess.SeedData;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UniveraDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlDb")));

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IProductService,ProductService>();

builder.Services.AddScoped<IProductRepository,EfProductRepository>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    DataGenerator.Initialize(services);
}


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
