using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteMongoDB.Middleware
{
    public static class TesteMiddlewareExtensions
    {
        public static IApplicationBuilder UseTesteMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TesteMiddleware>();
        }

    }
}
