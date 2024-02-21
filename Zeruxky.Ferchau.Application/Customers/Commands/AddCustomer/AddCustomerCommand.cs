namespace Zeruxky.Ferchau.Application.Customers.Commands.AddCustomer
{
    using MediatR;

    public record AddCustomerCommand : IRequest
    {
        public AddCustomerCommand(string firstName, string lastName, DateOnly dayOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DayOfBirth = dayOfBirth;
        }

        public string FirstName { get; }
        
        public string LastName { get; }
        
        public DateOnly DayOfBirth { get; }
    }
}