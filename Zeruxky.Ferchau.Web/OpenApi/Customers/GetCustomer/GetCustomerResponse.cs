namespace Zeruxky.Ferchau.Web.OpenApi.Customers.GetCustomer
{
    public record GetCustomerResponse
    {
        public Customer Customer { get; init; } = new();
    }
}