namespace Zeruxky.Ferchau.Persistence
{
    internal record CarRentalEntryDto
    {
        public CustomerDto Customer { get; set; }
        
        public CarDto Car { get; set; }
        
        public long MileageConsumption { get; set; }
    }
}