namespace Zeruxky.Ferchau.Application.Customers.Commands
{
    using Microsoft.Extensions.DependencyInjection;
    using Zeruxky.Ferchau.Application.Customers.Commands.AddCustomer;

    internal static class ServiceRegistration
    {
        internal static IServiceCollection AddCustomersCommands(this IServiceCollection services)
        {
            services.AddAddCustomerCommand();
            return services;
        }
    }
}