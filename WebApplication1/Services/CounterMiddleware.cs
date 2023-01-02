using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CounterMiddleware
    {
        private readonly RequestDelegate _next;

        int i = 0;

        public CounterMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        //public Task Invoke(HttpContext httpContext)
        //{

        //    return _next(httpContext);
        //}

        public async Task InvokeAsync(HttpContext httpcontext, ICounter counter, CounterService counterService)
        {
            i++; //счетчик запросов

            httpcontext.Response.ContentType = "text/html; charset = utf-8";

            await httpcontext.Response.WriteAsync($"Запрос {i}; Counter: {counter.Value}; Service: {counterService.Counter.Value}");
            
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CounterMiddlewareExtensions
    {
        public static IApplicationBuilder UseCounterMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CounterMiddleware>();
        }
    }
}
