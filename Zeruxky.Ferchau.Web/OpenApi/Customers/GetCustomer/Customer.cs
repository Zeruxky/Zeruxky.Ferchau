namespace Zeruxky.Ferchau.Web.OpenApi.Customers.GetCustomer
{
    public record Customer
    {
        public string FirstName { get; init; } = string.Empty;

        public string LastName { get; init; } = string.Empty;

        public DateOnly DayOfBirth { get; init; } = DateOnly.MinValue;
    }
}