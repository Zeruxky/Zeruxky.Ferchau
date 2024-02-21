namespace Zeruxky.Ferchau.Application.Customers.Commands.GetCustomer
{
    using Zeruxky.Ferchau.Domain;

    internal static class CustomerMapper
    {
        internal static CustomerDto ToDto(this Customer customer)
            => new()
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                DayOfBirth = customer.DayOfBirth,
            };
    }
}