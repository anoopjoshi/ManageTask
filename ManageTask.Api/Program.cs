using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<ManageTask.Infrastructure.Data.TaskManagementDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ManageTaskDbContext"));
});

builder.Services.AddTransient<ManageTask.Application.Interfaces.ITaskRepository, ManageTask.Infrastructure.Repositories.TaskRepository>();
builder.Services.AddTransient<ManageTask.Application.Interfaces.ITaskManager, ManageTask.Application.Services.TaskManager>();

/// <summary>
/// Adds the API explorer and Swagger generation services.
/// </summary>
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// allow any origin, method, and header
app.UseCors(builder => builder
     .AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
