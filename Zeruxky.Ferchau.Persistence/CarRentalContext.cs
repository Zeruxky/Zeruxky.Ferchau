namespace Zeruxky.Ferchau.Persistence
{
    using Microsoft.EntityFrameworkCore;

    internal class CarRentalContext : DbContext
    {
        public CarRentalContext(DbContextOptions<CarRentalContext> options)
            : base(options)
        {
        }
        
        public DbSet<CarDto> Cars { get; set; }
        
        public DbSet<CustomerDto> Customers { get; set; }
        
        public DbSet<CarRentalEntryDto> CarRentalEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarDto>().ToTable("Cars");
            modelBuilder.Entity<CustomerDto>()
                .ToTable("Customers")
                .HasKey(c => c.Id);
            modelBuilder.Entity<CarRentalEntryDto>().ToTable("CarRentals");
        }
    }
}