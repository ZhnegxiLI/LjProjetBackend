using Hangfire;
using LjDataAccess;
using LjDataAccess.Interfaces;
using LjWebApplication.IOC;
using LjWebApplication.Middleware;
using LjWebApplication.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;

namespace LjWebApplication
{
    public class Startup
    {
        public readonly IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // DI Controller + NewtonsoftJson format 
            IocConfiguration.NewtonsoftJsonIoc(services.AddControllers());

            // DI DBContext 
            services.AddDbContext<ERPDATA2Context>(
                options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));

            // DI JWT
            IocConfiguration.JwtIoc(services);

            // DI Cors
            IocConfiguration.CorsIoc(services, Configuration);

            // DI SignalR
            IocConfiguration.SignalRIoc(services);

            // DI Hangfire (配置定时任务)
            services.AddHangfire(x => x.UseSqlServerStorage(Configuration.GetConnectionString("DefaultConnectionString")));

            // DI Service repository 
            IocConfiguration.RepositoryIoc(services);

            // DI Swagger
            // IocConfiguration.SwaggerIoc(services);
            services.AddSwaggerGen(c =>
            {
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            });
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ISendMobilePushRepository sendMobilePushRepository)
        {
            // Proxy
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHangfireDashboard();

            RecurringJob.AddOrUpdate(() => sendMobilePushRepository.sendNotificationRequestAsync(), Cron.Minutely);

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "LJAPI");
            });

            app.UseErrorHandling();

            app.UseRouting();

            app.UseSentryTracing();

            app.UseCors();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<NotificationHub>("/notification/signalr");
                endpoints.MapControllerRoute(name: "default",
                       pattern: "{controller=Home}/{action=Index}/{id?}");
            });



        }
    }
}
