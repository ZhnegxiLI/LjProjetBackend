using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LjData.Models;
using LjDataAccess;
using LjDataAccess.Interfaces;
using LjDataAccess.Repositories;
using LjWebApplication.Middleware;
using LjWebApplication.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;
using Serilog;

namespace LjWebApplication
{
    public class Startup
    {
        private readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public readonly IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // No convert the upper case for the json property
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddJsonOptions(options => { options.SerializerSettings.ContractResolver = new DefaultContractResolver(); }); ;
            
            services.AddDbContext<ERPDATA2Context>(
                options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString"))
                );

            /* Configure the log with serilog */
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .CreateLogger();
            Log.Information("Start logging");

            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = "JwtBearer";
            //    options.DefaultChallengeScheme = "JwtBearer";
            //}).AddJwtBearer("JwtBearer", jwtBearerOptions =>
            //{
            //    jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Secret Key You Devise")),//TODO: Change into the appsetting.json
            //        ValidateIssuer = false, //TODO: Active the issuer and audience validation and set in the appsetting.json
            //        // ValidIssuer = "The name of the issuer",
            //        ValidateAudience = false,
            //        // ValidAudience = "The name of the audience",
            //        // ValidateLifetime = true, //validate the expiration and not before values in the token
            //        ClockSkew = TimeSpan.FromMinutes(5) //5 minute tolerance for the expiration date
            //    };
            //});

            services.AddAuthentication(options => {
                    options.DefaultAuthenticateScheme = "JwtBearer";
                    options.DefaultChallengeScheme = "JwtBearer";
                })
                .AddJwtBearer("JwtBearer", jwtBearerOptions =>
                {
                    jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Secret Key You Devise")),
                        ValidateIssuer= false,
                        //ValidIssuer = "The name of the issuer",
                        ValidateAudience = false,
                        //ValidAudience = "The name of the audience",
                        ValidateLifetime = true, //validate the expiration and not before values in the token
                        ClockSkew = TimeSpan.FromMinutes(5) //5 minute tolerance for the expiration date
                    };
                });

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:8080", "ionic://localhost","http://localhost", "http://localhost:8100", "http://176.176.221.117", "capacitor://localhost")
                            .AllowAnyHeader()
                            .AllowAnyMethod(); ;
                    });
            });

            // Dependencies injection
            services.AddSingleton<IStudentRepository, MockStudentRepository>(); // Only for test
            services.AddScoped<IAuthRepository, AuthRepositoryRepository>();
            services.AddScoped<IAccountRepository, AccountRepositoryRepository>();
            services.AddScoped<ICargoRepository, CargoRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<ISalesOrderRepository, SalesOrderRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Proxy
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            if (!env.IsDevelopment())
            {
                app.UseForwardedHeaders(new ForwardedHeadersOptions
                {
                    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
                });
            }
 
            app.UseCors(MyAllowSpecificOrigins);

            app.UseErrorHandling();

            //app.UseStatusCodePages();
            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
