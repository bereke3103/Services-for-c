using WebApplication1.Services;

var builder = WebApplication.CreateBuilder();

builder.Services.AddTransient<ICounter, RandomCounter>();
builder.Services.AddTransient<CounterService>();

var app = builder.Build();

app.UseMiddleware<CounterMiddleware>();

app.Run();