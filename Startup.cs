/*Guida che ho seguito:
 * https://medium.freecodecamp.org/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28
 */

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CRUD_Angular.Domain.Repositories;
using CRUD_Angular.Domain.Services;
using CRUD_Angular.Persistence.Contexts;
using CRUD_Angular.Persistence.Repositories;
using CRUD_Angular.Services;
using AutoMapper;

namespace CRUD_Angular
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            /* Qui configuriamo il contesto del database. Diciamo ad ASP.NET Core di utilizzare AppDbContext 
             * con un'implementazione del database in memoria, identificata dalla stringa passata 
             * come argomento del nostro metodo. Di solito, il provider in memoria viene utilizzato 
             * quando scriviamo test di integrazione, ma lo sto usando qui per semplicità. 
             * In questo modo non è necessario connettersi a un vero database per testare l'applicazione.*/
            services.AddDbContext<AppDbContext>(options => {
                options.UseInMemoryDatabase("supermarket-api-in-memory");
            });

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Carico Product
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            //Fine Carico Product

            //Carico Automapper
            /* AutoMapper è una piccola libreria semplice creata per risolvere 
             * un problema apparentemente complesso, eliminando il codice che 
             * associava un oggetto a un altro. 
             * Questo tipo di codice è piuttosto noioso e noioso da scrivere*/
            services.AddAutoMapper();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
