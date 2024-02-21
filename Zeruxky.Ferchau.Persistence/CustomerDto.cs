namespace Zeruxky.Ferchau.Persistence
{
    internal record CustomerDto
    {
        public Guid Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public DateOnly DayOfBirth { get; set; }
        
        public CarDto? RentedCar { get; set; }
    }
}