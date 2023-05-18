using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S3API
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Net;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class S3ExceptionMiddleware
    {
        private readonly RequestDelegate next;

        public S3ExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var errorMessage = "Internal Server Error.";

            // Check if the exception has a custom message
            if (exception is ApplicationException appException)
            {
                errorMessage = appException.Message;
            }

            var response = new
            {
                StatusCode = context.Response.StatusCode,
                Message = errorMessage
            };
            var jsonResponse = JsonSerializer.Serialize(response);

            return context.Response.WriteAsync(jsonResponse);
     
        }

    }

    public static class ExceptionMiddlewareExtensions
    {
        public static void UseCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<S3ExceptionMiddleware>();
        }
    }

}
