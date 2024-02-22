namespace Zeruxky.Ferchau.Application.Customers.Commands
{
    using Microsoft.Extensions.DependencyInjection;
    using Zeruxky.Ferchau.Application.Customers.Commands.AddCustomer;
    using Zeruxky.Ferchau.Application.Customers.Commands.GetCustomer;

    internal static class ServiceRegistration
    {
        internal static IServiceCollection AddCustomersCommands(this IServiceCollection services)
        {
            services.AddGetCustomerCommand();
            services.AddAddCustomerCommand();
            return services;
        }
    }
}