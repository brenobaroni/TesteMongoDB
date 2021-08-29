using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteMongoDB.Middleware
{

    public class TesteMiddleware
    {
        private readonly RequestDelegate _next;

        public TesteMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var endPoint = context.GetEndpoint();
            Console.WriteLine(context.Request.Path.Value);
            Console.WriteLine($"Valid end Point Request: {endPoint != null}");
            if(endPoint == null)
                await _next(context);

            Console.WriteLine("Saída");
        }


    }
}
