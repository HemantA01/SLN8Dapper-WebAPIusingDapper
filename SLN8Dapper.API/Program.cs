using Microsoft.EntityFrameworkCore;
using SLN8Dapper.DATA.DBContext;
using SLN8Dapper.SERVICE.IService;
using SLN8Dapper.SERVICE.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DbConn")));
builder.Services.AddSingleton<DapperContext>();
builder.Services.AddScoped<IUserRegistration, UserRegistration>();
builder.Services.AddScoped<ICountryMaster, CountryMaster>();
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
