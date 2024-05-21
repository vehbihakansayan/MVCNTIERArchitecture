using NorthwndCompany.Infrastructure.Utilities.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using NorthwndCompany.VektorelMVCProject.ApiServices;
using System;
using FluentValidation.AspNetCore;

namespace NorthwndCompany.VektorelMVCProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews()
                    .AddRazorRuntimeCompilation();

            //[ModelStateFilter] attirubute nin kullanýldýðý yerlerde EntityValidator'e gitsin diye yazdýðýmýz kod
            services.AddMvc().AddFluentValidation(opt => { opt.RegisterValidatorsFromAssemblyContaining<Startup>(); });

            services.AddHttpClient<ProductApiService>(x =>
            {
                x.BaseAddress = new Uri(Configuration.GetSection("ApiBaseAddress").Value);
            });

            services.AddHttpClient<CategoryApiService>(x =>
            {
                x.BaseAddress = new Uri(Configuration.GetSection("ApiBaseAddress").Value);
            });

            services.AddHttpClient<EmployeeApiService>(x =>
            {
                x.BaseAddress = new Uri(Configuration.GetSection("ApiBaseAddress").Value);
            });

            services.AddHttpClient<CountryApiService>(x =>
            {
                x.BaseAddress = new Uri(Configuration.GetSection("ApiBaseAddress").Value);
            });

            services.AddHttpClient<CityApiService>(x =>
            {
                x.BaseAddress = new Uri(Configuration.GetSection("ApiBaseAddress").Value);
            });
            services.AddHttpClient<OrderApiService>(x =>
            {
                x.BaseAddress = new Uri(Configuration.GetSection("ApiBaseAddress").Value);
            });
            services.AddHttpClient<CustomerApiService>(x =>
            {
                x.BaseAddress = new Uri(Configuration.GetSection("ApiBaseAddress").Value);
            });

            services.AddSession();

            TokenOption tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOption>();

            services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(token =>
                {
                    token.RequireHttpsMetadata = false;
                    token.SaveToken = true;
                    token.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey),
                        ValidateIssuer = true,
                        ValidIssuer = tokenOptions.Issuer,
                        ValidateAudience = true,
                        ValidAudience = tokenOptions.Audience,
                        RequireExpirationTime = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero
                    };
                });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.Use(async (context, next) =>
            {
                var JWToken = context.Session.GetString("LoggedInUserToken");
                if (!string.IsNullOrEmpty(JWToken))
                {
                    context.Request.Headers.Add("Authorization", "Bearer " + JWToken);
                }
                await next();
            });

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "adminLogIn",
                    areaName: "Admin",
                    pattern: "Admin/{controller=AdminAuth}/{action=LogIn}");


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Auth}/{action=LogIn}/{id?}");
            });
        }
    }
}