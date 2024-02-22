namespace Zeruxky.Ferchau.Web.OpenApi.Customers.GetCustomer
{
    using FastEndpoints;

    public record GetCustomerRequest
    {
        [BindFrom("customerId")]
        public Guid CustomerId { get; init; } = Guid.Empty;
    }
}