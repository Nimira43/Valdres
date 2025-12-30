using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>(opt =>
{
  opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IProductRepository, ProductsRepository>();

var app = builder.Build();

app.MapControllers();

try
{
  using var scope = app.Services.CreateScope();
}
catch (System.Exception)
{
  
  throw;
}

app.Run();
