using Microsoft.EntityFrameworkCore;
using ProductMiniFullstckApi.Models.Domain;
using ProductMiniFullstckApi.Repositories.Abstract;
using ProductMiniFullstckApi.Repositories.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DatabaseContext>(options =>
     options.UseSqlServer(builder.Configuration.GetConnectionString("conn")));
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseCors(
             options =>
             options.WithOrigins("*").AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
