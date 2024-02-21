namespace Zeruxky.Ferchau
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Serilog;
    using Zeruxky.Ferchau.Web;

    public static class Program
    {
        public static Task Main(string[] args) => CreateHostBuilder(args)
            .Build()
            .RunAsync();

        private static IWebHostBuilder CreateHostBuilder(string[] args)
            => WebHost.CreateDefaultBuilder<Startup>(args)
                .ConfigureLogging(builder => { builder.AddSerilog(); });
    }
}