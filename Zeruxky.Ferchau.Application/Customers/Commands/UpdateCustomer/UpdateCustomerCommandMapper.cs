namespace Zeruxky.Ferchau.Application.Customers.Commands.UpdateCustomer
{
    using Zeruxky.Ferchau.Domain;

    internal static class UpdateCustomerCommandMapper
    {
        internal static Customer ToCustomer(this UpdateCustomerCommand command)
            => new(new CustomerId(command.CustomerId), command.FirstName, command.LastName, command.DayOfBirth);
    }
}