namespace Zeruxky.Ferchau.Persistence
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Zeruxky.Ferchau.Domain;

    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddDbContext<CarRentalContext>(
                (serviceProvider, options) =>
                {
                    var configuration = serviceProvider.GetRequiredService<IConfiguration>();
                    options.UseSqlite(configuration.GetConnectionString("RentalCarsContext"));
                });
            services.AddTransient<ICustomerRepository, CarRentalRepository>();
            return services;
        }
    }
}