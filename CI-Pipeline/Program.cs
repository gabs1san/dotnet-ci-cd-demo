using Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TaskService>();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();