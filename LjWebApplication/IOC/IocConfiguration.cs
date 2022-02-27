using LjData.Utils;
using LjDataAccess.Interfaces;
using LjDataAccess.Repositories;
using LjWebApplication.Model;
using LjWebApplication.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace LjWebApplication.IOC
{
    public static class IocConfiguration
    {


        public static void JwtIoc(IServiceCollection services)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "JwtBearer";
                options.DefaultChallengeScheme = "JwtBearer";
            })
            .AddJwtBearer("JwtBearer", jwtBearerOptions =>
            {
                jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Secret Key You Devise")),
                    ValidateIssuer = false,
                    //ValidIssuer = "The name of the issuer",
                    ValidateAudience = false,
                    //ValidAudience = "The name of the audience",
                    ValidateLifetime = true, //validate the expiration and not before values in the token
                    ClockSkew = TimeSpan.FromMinutes(5) //5 minute tolerance for the expiration date
                };
            });
        }

        public static void RepositoryIoc(IServiceCollection services)
        {
            // Dependencies injection
            services.AddSingleton<IStudentRepository, MockStudentRepository>(); // Only for test
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<ICargoRepository, CargoRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<ISalesOrderRepository, SalesOrderRepository>();
            services.AddScoped<IVersionRepository, VersionRepository>();
            services.AddScoped<IUserPermission, UserPermission>();
            services.AddScoped<ISseRepository, SseRepository>();
            services.AddScoped<ISendMobilePushRepository, SendMobilePushRepository>();
            services.AddScoped<ICommodityStockRepository, CommodityStockRepository>();

            //services.AddScoped<ISqlListenerRepository, SqlListenerRepository>();
        }

        public static void CorsIoc(IServiceCollection services, IConfiguration Configuration)
        {
            var hosts = Configuration.GetSection("Cors:AllowedOrigins").Get<List<string>>();
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.WithOrigins(hosts.ToArray())
                            .AllowAnyHeader()
                            .WithMethods()
                            .AllowCredentials(); ;
                    });
            });

        }

        public static void NewtonsoftJsonIoc(IMvcBuilder services)
        {
            services.AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                options.SerializerSettings.DateFormatString = "yyyy-MM-dd";

            });
        }
        public static void SignalRIoc(IServiceCollection services)
        {
            services.AddSingleton<NotificationEvent>();
            services.AddSingleton<NotificationService>();
            services.AddSignalR();//前后端通讯集成，支持分组发送
        }
    }
}
