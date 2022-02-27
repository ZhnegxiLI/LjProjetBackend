using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;

namespace LjWebApplication.Middleware
{

    public static class SseExtensions
    {
        public static void UseSse(this IApplicationBuilder builder)
        {
            builder.Use(async (context, next) =>
            {
                if (context.Request.Headers["Accept"] == "text/event-stream")
                {
                    var response = context.Response;
                    response.Headers.Add("Content-Type", "text/event-stream");
                    response.Body.Flush();

                    context.RequestAborted.WaitHandle.WaitOne();

                    await Task.FromResult(true);
                }
                else
                {
                    await next.Invoke();
                }
            });
        }
    }
}
