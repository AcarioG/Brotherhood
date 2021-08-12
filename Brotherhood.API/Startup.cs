using Brotherhood.Domain.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Brotherhood.Repository.Interfaces;
using Brotherhood.Repository.Repositories;
using Brotherhood.Services.UnitOfWork;
using Brotherhood.Services.Interfaces;
using Brotherhood.Services.Service;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Brotherhood.API.Helpers;
using Microsoft.OpenApi.Models;
using Microsoft.Net.Http.Headers;

namespace Brotherhood.API
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
            services.AddControllersWithViews();
            //            .AddJsonOptions(o => o.JsonSerializerOptions
            //            .ReferenceHandler = ReferenceHandler.Preserve);
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Brotherhood"),b => b.MigrationsAssembly("Brotherhood.API"));
            });
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });


            services.AddTransient<IFileUpload, FileUploadAzure>();
            services.AddTransient<IChapterRepository, ChapterRepository>();
            services.AddTransient<IComicsRepository, ComicsRepository>();
            services.AddTransient<IUnitOfWorkRepository, UnitOfWorkRepository>();
            services.AddTransient<IChapterServices, ChapterService>();
            services.AddTransient<IComicServices, ComicsService>();

            services.AddSwaggerGen(setup =>
            {
                setup.SwaggerDoc("v1", new OpenApiInfo() { Title = "Documentation", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(setup =>
            {
                setup.SwaggerEndpoint("/swagger/v1/swagger.json", "SwaggerDocumentation v1");
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors("CorsPolicy");

           //app.UseCors("CorsPolicy", policy =>
           //            policy.WithOrigins("http://localhost:5000", "https://localhost:5001")
           //                  .AllowAnyMethod()
           //                  .WithHeaders(HeaderNames.ContentType, HeaderNames.Authorization, "x-custom-header")
           //                  .AllowCredentials());

           app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
