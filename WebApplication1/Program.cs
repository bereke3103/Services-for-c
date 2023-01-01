using WebApplication1.Services;

var builder = WebApplication.CreateBuilder();


builder.Services.AddTransient<GetTimeService>();

var app = builder.Build();

app.Run(async context=>
{
    var timeService = app.Services.GetService<GetTimeService>();

    await context.Response.WriteAsync($"Time: {timeService?.GetTime()}");
});

app.Run();


