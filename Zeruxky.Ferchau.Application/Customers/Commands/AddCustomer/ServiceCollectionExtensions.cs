namespace Zeruxky.Ferchau.Application.Customers.Commands.AddCustomer
{
    using Microsoft.Extensions.DependencyInjection;

    internal static class ServiceCollectionExtensions
    {
        internal static IServiceCollection AddAddCustomerCommand(this IServiceCollection services)
        {
            services.AddRequestHandler<AddCustomerCommand, AddCustomerCommandHandler>();
            return services;
        }
    }
}