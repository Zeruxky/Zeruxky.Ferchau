namespace Zeruxky.Ferchau.Persistence
{
    public record CustomerDto
    {
        public Guid Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public DateOnly DayOfBirth { get; set; }
        
        public Guid RentedCarId { get; set; }
        
        public CarDto? RentedCar { get; set; }

        public IEnumerable<CarRentalEntryDto> RentalEntries { get; set; } = Array.Empty<CarRentalEntryDto>();
    }
}