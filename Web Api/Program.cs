using Microsoft.EntityFrameworkCore;
using SchoolProject.Core;
using SchoolProject.Infrustructer;
using SchoolProject.Infrustructer.Abstracts;
using SchoolProject.Infrustructer.Data;
using SchoolProject.Infrustructer.Repositories;
using SchoolProject.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Connection to SQL SERVER
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbcontext"));
});

#region Depandency Injection
builder.Services.AddInfurstructerDepandencies()
                .AddServiceDepandencies()
                .AddModuleCoreDepandencies();
#endregion

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
