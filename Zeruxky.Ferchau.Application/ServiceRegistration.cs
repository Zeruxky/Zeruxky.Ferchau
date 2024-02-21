namespace Zeruxky.Ferchau.Application
{
    using Microsoft.Extensions.DependencyInjection;
    using Zeruxky.Ferchau.Application.Customers;

    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddCustomersApplication();
            return services;
        }
    }
}