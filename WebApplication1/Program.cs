using WebApplication1.Services;

var builder = WebApplication.CreateBuilder();


builder.Services.AddTransient<ITimeService, ShortTimeService>();

var app = builder.Build();

app.Run(async context=>
{
    var timeService = app.Services.GetService<ITimeService>();

    await context.Response.WriteAsync($"Time: {timeService.GetTime()}");
});

app.Run();


