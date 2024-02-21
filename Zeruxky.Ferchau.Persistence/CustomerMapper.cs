namespace Zeruxky.Ferchau.Persistence
{
    using Zeruxky.Ferchau.Domain;

    internal static class CustomerMapper
    {
        internal static CustomerDto ToDto(this Customer customer)
            => new()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                DayOfBirth = customer.DayOfBirth,
                RentedCar = customer.RentedCar?.ToDto(),
            };
    }
}