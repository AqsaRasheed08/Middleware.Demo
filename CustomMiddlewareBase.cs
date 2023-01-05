﻿using Microsoft.AspNetCore.Http;
namespace Middleware.Demo
{
    public class CustomMiddlewareBase : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Custom Middleware Incoming Request \n");
            await next(context);
            await context.Response.WriteAsync("Custom Middleware Outgoing Request \n");
        }

    }
}