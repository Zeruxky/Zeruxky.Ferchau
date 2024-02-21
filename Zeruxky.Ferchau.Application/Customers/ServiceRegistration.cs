namespace Zeruxky.Ferchau.Application.Customers
{
    using Microsoft.Extensions.DependencyInjection;
    using Zeruxky.Ferchau.Application.Customers.Commands;

    internal static class ServiceRegistration
    {
        internal static IServiceCollection AddCustomersApplication(this IServiceCollection services)
        {
            services.AddCustomersCommands();
            return services;
        }
    }
}