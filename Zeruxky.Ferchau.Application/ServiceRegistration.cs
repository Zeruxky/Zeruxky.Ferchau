namespace Zeruxky.Ferchau.Application
{
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;
    using Zeruxky.Ferchau.Application.Customers;

    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddCustomersApplication();
            services.AddTransient<IMediator, Mediator>();
            services.AddTransient<ISender>(sp => sp.GetRequiredService<IMediator>());
            return services;
        }
    }
}