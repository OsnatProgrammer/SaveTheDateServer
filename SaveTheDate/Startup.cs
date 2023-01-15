using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SaveTheDate.BL;
using SaveTheDate.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;


namespace SaveTheDate
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
            services.AddControllers();

            services.AddScoped<IEventDL, EventDL>();
            services.AddScoped<IEventBL, EventBL>();

            services.AddScoped<IBusDL, BusDL>();
            services.AddScoped<IBusBL, BusBL>();

            services.AddScoped<IEventGiftDL, EventGiftDL>();
            services.AddScoped<IEventGiftBL, EventGiftBL>();

            // services.AddScoped<IEventTypeDL, EventTypeDL>();
            // services.AddScoped<IEventTypeBL, EventTypeBL>();

            //services.AddScoped<IGiftCategoryDL, GiftCategoryDL>();
            //services.AddScoped<IGiftCategoryBL, GiftCategoryBL>();

            services.AddScoped<IGiftDL, GiftDL>();
            services.AddScoped<IGiftBL, GiftBL>();

             services.AddScoped<IGuestDL, GuestDL>();
             services.AddScoped<IGuestBL, GuestBL>();

            services.AddScoped<ITableDL, TableDL>();
            services.AddScoped<ITableBL, TableBL>();

            services.AddScoped<IUserDL, UserDL>();
            services.AddScoped<IUserBL, UserBL>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SaveTheDate", Version = "v1" });
            });

            //    options.AddDefaultPolicy(
            //    builder =>
            //    {
            //        builder.WithOrigins("https://localhost:44331")
            //        .AllowAnyHeader()
            //        .AllowAnyMethod()
            //        .AllowCredentials();
            //    });
            //});


            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigins", builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                       .AllowAnyHeader().WithMethods("PUT", "DELETE", "GET", "POST")

            .AllowAnyMethod()
            .AllowCredentials();

                });
            });

           // services.AddCors(options =>
           // {
           //     options.AddPolicy("MyAllowSpecificOrigins", builder =>
           //     {
           //         builder.WithOrigins("http://localhost:4200")
           //         .AllowAnyHeader()
           //         .AllowAnyMethod();
           //     });
           //});

            //JSON
            services.AddControllersWithViews().AddNewtonsoftJson(options =>

            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore).
                AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CoronaManagementSystemHMO.API v1"));
            }

            

            app.UseCors("AllowSpecificOrigins");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
