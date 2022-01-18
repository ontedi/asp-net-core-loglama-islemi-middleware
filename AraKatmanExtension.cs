using Microsoft.AspNetCore.Builder;
namespace AspNetCoreMiddleware
{
    public static class AraKatmanExtension
    {
        public static IApplicationBuilder AraKatmanlar(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoglamaIslemiMiddleware>();
        }
    }
}
