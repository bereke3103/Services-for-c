//using System.Text;

//var builder = WebApplication.CreateBuilder(args);



//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();



//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();






using System.Text;

var builder = WebApplication.CreateBuilder();

builder.Services.AddTransient<ITimeService, ShortTimeService>();

var app = builder.Build();

app.Run(async context =>
{
var timeService = app.Services.GetService<ITimeService>();
await context.Response.WriteAsync($"Time: {timeService?.GetTime()}");
});

app.Run();

interface ITimeService
{
    string GetTime();
}
// ����� � ������� hh::mm
class ShortTimeService : ITimeService
{
    public string GetTime() => DateTime.Now.ToShortTimeString();
}
// ����� � ������� hh::mm::ss
class LongTimeService : ITimeService
{
    public string GetTime() => DateTime.Now.ToLongTimeString();
}

//var builder = WebApplication.CreateBuilder();

//var services = builder.Services;

//var app = builder.Build();

//app.Run(async context =>
//{
//    var sb = new StringBuilder();
//    sb.Append("<h1>��� �������</h1>");
//    sb.Append("<table>");
//    sb.Append("<tr><th>���</th><th>Lifetime</th><th>����������</th></tr>");
//    foreach (var svc in services)
//    {
//        sb.Append("<tr>");
//        sb.Append($"<td>{svc.ServiceType.FullName}</td>");
//        sb.Append($"<td>{svc.Lifetime}</td>");
//        sb.Append($"<td>{svc.ImplementationType?.FullName}</td>");
//        sb.Append("</tr>");
//    }
//    sb.Append("</table>");
//    context.Response.ContentType = "text/html;charset=utf-8";
//    await context.Response.WriteAsync(sb.ToString());
//});

//app.Run();
