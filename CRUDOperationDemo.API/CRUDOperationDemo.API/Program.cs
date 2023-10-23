using CRUDOperationDemo.API.Controllers;
using CRUDOperationDemo.API.Data;
using CRUDOperationDemo.API.Services;
using CRUDOperationDemo.API.Services.Base;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.
    AddDbContext<ApplicationDbContext>(options => options.
    UseSqlServer(builder.Configuration.
    GetConnectionString("connectionString")
    ));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<IStudentService,StudentService>();
builder.Services.AddTransient<StudentController>();


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
