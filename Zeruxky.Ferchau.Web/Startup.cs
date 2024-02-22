namespace Zeruxky.Ferchau.Web
{
    using FastEndpoints;
    using FastEndpoints.Swagger;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Zeruxky.Ferchau.Web.OpenApi;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }
        
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOpenApi();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseSwaggerGen();

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseEndpoints(
                builder =>
                {
                    builder.MapFastEndpoints();
                    builder.MapSwagger();
                });
        }
    }
}