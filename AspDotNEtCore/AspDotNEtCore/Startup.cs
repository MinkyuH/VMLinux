using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspDotNEtCore.models;
using AspDotNEtCore.Repositories;
using AspDotNEtCore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace AspDotNEtCore
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
            services.AddDbContext<TestDbContext>(Options => Options.UseSqlServer("Server=tcp:webapptestnodesql.database.windows.net,1433;Initial Catalog=sampleTestdb;Persist Security Info=False;User ID=kan02100;Password=Steven1995;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));
            services.AddScoped<UserRepository>();
            services.AddScoped<AddressRepository>();
            services.AddScoped<CustomAuthenticationService>();
            services.AddAuthentication("COOKIE_SCHEME").AddCookie("COOKIE_SCHEME");
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
