namespace Zeruxky.Ferchau.Persistence
{
    public record CarDto
    {
        public Guid Id { get; set; }
        
        public string Manufacturer { get; set; }
        
        public string ModelName { get; set; }
        
        public long Mileage { get; set; }
        
        public RentalStateDto RentalState { get; set; }
        
        public Guid TenantId { get; set; }
        
        public CustomerDto Tenant { get; set; }

        public IEnumerable<CarRentalEntryDto> RentalEntries { get; set; } = Array.Empty<CarRentalEntryDto>();
    }
}