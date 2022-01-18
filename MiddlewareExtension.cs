using Microsoft.AspNetCore.Builder;
namespace AspNetCoreMiddleware
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder UseHeaderCheckMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoglamaIslemiMiddleware>();
        }
    }
}
