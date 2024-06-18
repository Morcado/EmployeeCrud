using EmployeeCRUD.Data.Attributes;
using EmployeeCRUD.Data.DbContexts;
using EmployeeCRUD.Data.Repositories;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>((optionsBuilder, optionsAction) =>
{
    optionsAction.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
        .AddInterceptors(optionsBuilder.GetRequiredService<SoftDeleteInterceptor>());
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();
builder.Services.AddScoped<IDireccionRepository, DireccionRepository>();
builder.Services.AddScoped<ITelefonoRepository, TelefonoRepository>();

builder.Services.AddSingleton<SoftDeleteInterceptor>();

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
