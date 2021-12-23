using App.Config;
using App.Domain;
using App.Infrastructure.Data;
using App.Infrastructure.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web
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

            //Vamos a decirle que el contexto va a utilizar la cadena de conexión del App.settings
            services.AddDbContext<Estado_PedidosContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Estado_Pedidos"))
            );

            //En esta sección vamos a resolver las inyecciones de dependencias
            services.AddTransient<ISpecialMeasureRepository, SpecialMeasureRepository>();
            services.AddTransient<ISpecialMeasureService, SpecialMeasureService>();

            //Configuración del mapper
            var mapperConfig = new MapperConfiguration(m =>
            {
                m.AddProfile(new AutoMapperConfig());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvcCore();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
