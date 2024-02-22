namespace Zeruxky.Ferchau.Application.Customers.Commands.AddCustomer
{
    using Zeruxky.Ferchau.Domain;

    internal static class AddCustomerCommandMapper
    {
        internal static Customer ToCustomer(this AddCustomerCommand command)
            => new(CustomerId.NewId(), command.FirstName, command.LastName, command.DayOfBirth);
    }
}