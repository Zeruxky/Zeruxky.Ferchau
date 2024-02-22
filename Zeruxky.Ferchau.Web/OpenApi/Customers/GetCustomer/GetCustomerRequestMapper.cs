namespace Zeruxky.Ferchau.Web.OpenApi.Customers.GetCustomer
{
    using Zeruxky.Ferchau.Application.Customers.Commands.GetCustomer;

    internal static class GetCustomerRequestMapper
    {
        internal static GetCustomerCommand ToCommand(this GetCustomerRequest request)
            => new(request.CustomerId);
    }
}