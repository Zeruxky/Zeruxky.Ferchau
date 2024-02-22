namespace Zeruxky.Ferchau.Persistence
{
    using Microsoft.EntityFrameworkCore;
    using SmartEnum.EFCore;

    public class CarRentalContext : DbContext
    {
        public CarRentalContext(DbContextOptions<CarRentalContext> options)
            : base(options)
        {
        }
        
        public DbSet<CarDto> Cars { get; set; }
        
        public DbSet<CustomerDto> Customers { get; set; }
        
        public DbSet<CarRentalEntryDto> CarRentalEntries { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.ConfigureSmartEnum();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarDto>()
                .ToTable("Cars")
                .HasKey(c => c.Id);
            modelBuilder.Entity<CustomerDto>()
                .HasOne<CarDto>(customer => customer.RentedCar)
                .WithOne(car => car.Tenant)
                .HasForeignKey<CarDto>(c => c.TenantId);
            modelBuilder.Entity<CustomerDto>().ToTable("Customers");
            modelBuilder.Entity<CustomerDto>().HasKey(c => c.Id);

            modelBuilder.Entity<CarRentalEntryDto>()
                .ToTable("CarRentals")
                .HasKey(c => new { c.CarId, c.TenantId, c.MileageConsumption });
        }
    }
}