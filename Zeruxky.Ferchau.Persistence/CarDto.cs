namespace Zeruxky.Ferchau.Persistence
{
    public record CarDto
    {
        public string Manufacturer { get; set; }
        
        public string ModelName { get; set; }
        
        public long Mileage { get; set; }
        
        public RentalStateDto RentalState { get; set; }
    }
}