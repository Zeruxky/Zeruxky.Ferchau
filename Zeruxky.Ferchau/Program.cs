namespace Zeruxky.Ferchau
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Serilog;
    using Zeruxky.Ferchau.Application;
    using Zeruxky.Ferchau.Persistence;
    using Zeruxky.Ferchau.Web;

    public static class Program
    {
        public static Task Main(string[] args) => CreateHostBuilder(args)
            .Build()
            .RunAsync();

        private static IWebHostBuilder CreateHostBuilder(string[] args)
            => WebHost.CreateDefaultBuilder<Startup>(args)
                .ConfigureLogging(builder => { builder.AddSerilog(); })
                .ConfigureAppConfiguration(
                    (context, builder) =>
                    {
                        builder.AddJsonFile("./Config/appsettings.json", false, true);
                        builder.AddJsonFile(
                            $"./Config/appsettings.{context.HostingEnvironment.EnvironmentName}.json",
                            true,
                            true);
                    })
                .ConfigureServices(
                    (context, services) =>
                    {
                        services.AddPersistence(context.Configuration);
                        services.AddApplication();
                    });
    }
}