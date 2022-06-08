using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using Swashbuckle.AspNetCore.Swagger;
using P9.Server.DB;
using Microsoft.EntityFrameworkCore;

namespace P9.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            services.AddRazorPages();
            var sqlConnectionString = "Host=ec2-54-91-188-254.compute-1.amazonaws.com;Port=5432;Username=pnferzdgqughwr;Database =d95cre0dhl30ga;Password=530471a841b84320b4f70835b069ae2f9421d73b26e6d673feedb9fc9adc6e23;sslmode=Prefer;Trust Server Certificate=true;";
            services.AddDbContext<ClotheDbContext>(options => options.UseNpgsql(sqlConnectionString));
            services.AddScoped<ClotheProvider>();
            services.AddDbContext<UserDbContext>(options => options.UseNpgsql(sqlConnectionString));
            services.AddScoped<UserProvider>();
            services.AddMvc(); 
            services.AddSwaggerGen(c => 
            {
                c.SwaggerDoc("a1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "API Title is",
                    Version = "a1"
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
            app.UseSwagger();
            app.UseSwaggerUI(c=>
            {
                c.SwaggerEndpoint("/swagger/a1/swagger.json", "a1 api test");
            });
        }
    }
}
