using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class HelloMiddleware
    {
        readonly IEnumerable<IHelloService> helloServices;
        public HelloMiddleware(RequestDelegate _, IEnumerable<IHelloService> helloServices)
        {
            this.helloServices = helloServices;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.ContentType = "text/html; charset=utf-8";
            string responseTest = "";
            foreach (var service in helloServices)
            {
                responseTest += $"<h3>{service.Message}</h3>";
            }
            await context.Response.WriteAsync(responseTest);
        }
    }
}
