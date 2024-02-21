namespace Zeruxky.Ferchau.Web.OpenApi.Customers.AddCustomer
{
    public record AddCustomerRequest
    {
        public string FirstName { get; init; }

        public string LastName { get; init; }

        public DateOnly DayOfBirth { get; init; }
    }
}