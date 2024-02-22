namespace Zeruxky.Ferchau.Persistence
{
    public record CarRentalEntryDto
    {
        public Guid TenantId { get; set; }
        
        public CustomerDto Tenant { get; set; }
        
        public Guid CarId { get; set; }
        
        public CarDto Car { get; set; }
        
        public long MileageConsumption { get; set; }
    }
}