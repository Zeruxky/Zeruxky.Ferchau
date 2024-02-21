namespace Zeruxky.Ferchau.Application.Customers.Commands.GetCustomer
{
    public record CustomerDto
    {
        public Guid Id { get; init; }
        
        public string FirstName { get; init; }
        
        public string LastName { get; init; }
        
        public DateOnly DayOfBirth { get; init; }
    }
}