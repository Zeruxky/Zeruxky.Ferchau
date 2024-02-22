namespace Zeruxky.Ferchau.Web.OpenApi.Customers.GetCustomer
{
    using Zeruxky.Ferchau.Application.Customers.Commands.GetCustomer;

    internal static class CustomerDtoMapper
    {
        internal static Customer ToCustomer(this CustomerDto dto)
            => new()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                DayOfBirth = dto.DayOfBirth,
            };
    }
}