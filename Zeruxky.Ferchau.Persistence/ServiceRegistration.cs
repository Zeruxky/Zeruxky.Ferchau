namespace Zeruxky.Ferchau.Persistence
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Zeruxky.Ferchau.Domain;

    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSqlServer<CarRentalContext>(configuration.GetConnectionString(ConnectionStrings.CarRentalsContext));
            services.AddTransient<ICustomerRepository, CarRentalRepository>();
            return services;
        }
    }
}