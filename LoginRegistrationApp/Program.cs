using Microsoft.EntityFrameworkCore;
using LoginRegistrationApp.Data;
using LoginRegistrationApp.Controllers.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
//using LoginRegistrationApp.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionstring = builder.Configuration.GetConnectionString("GSAM"); //get connection string of our application

builder.Services.AddDbContext<ApplicationDbContext>(options=>options.UseSqlServer(connectionstring));

builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    options.User.RequireUniqueEmail = true;
}
).AddEntityFrameworkStores<ApplicationDbContext>()//configure users to use unique email address
.AddDefaultTokenProviders();//enable to reset passwords

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


if (app.Environment.IsDevelopment())
{
   app.UseHttpsRedirection();
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseAuthorization();


app.Run();
