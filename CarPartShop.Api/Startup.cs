using Autofac;
using Autofac.Extensions.DependencyInjection;
using CarPartShop.PersistenceEF;
using CarPartShop.PersistenceEF.Repository;
using CarPartShop.Services;
using CarPartShop.Services.CarBrands;
using CarPartShop.Services.CarBrands.Contracts;
using CarPartShop.Services.CarModels;
using CarPartShop.Services.CarModels.Contracts;
using CarPartShop.Services.RepositoryContracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Linq;
using System.Reflection;

namespace CarPartShop.Api
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
            var ConnectionString = Configuration.GetConnectionString("CarPartShop");
            services.AddDbContext<EfCarPartContext>(options => options.UseSqlServer(ConnectionString));

            services.AddAutofac();

            services.AddScoped<CarBrandRepository, EFCarBrandRepository>();
            services.AddScoped<CarModelRepository, EFCarModelRepository>();
            services.AddScoped<CarBrandService, CarBrandAppService>();
            services.AddScoped<CarModelService, CarModelAppService>();
            services.AddScoped<UnitOfWork, EFUnitOfWork>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CarPartShop.Api", Version = "v1" });
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            //builder.RegisterType<CarModelAppService>().As<CarModelService>();
            //builder.RegisterType<CarBrandAppService>().As<CarBrandService>();
            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(Services)))
            //    .Where(_ => _.Namespace.Contains("Service"))
            //    .AsImplementedInterfaces(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CarPartShop.Api v1"));
            }

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
