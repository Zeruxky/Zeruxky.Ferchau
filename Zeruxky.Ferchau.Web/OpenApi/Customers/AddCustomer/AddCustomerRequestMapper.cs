namespace Zeruxky.Ferchau.Web.OpenApi.Customers.AddCustomer
{
    using Zeruxky.Ferchau.Application.Customers.Commands.AddCustomer;

    internal static class AddCustomerRequestMapper
    {
        internal static AddCustomerCommand ToCommand(this AddCustomerRequest request)
            => new(request.FirstName, request.LastName, request.DayOfBirth);
    }
}