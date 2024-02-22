namespace Zeruxky.Ferchau.Persistence
{
    using Zeruxky.Ferchau.Domain;

    internal static class CustomerDtoMapper
    {
        internal static Customer ToCustomer(this CustomerDto dto)
            => new(new CustomerId(dto.Id), dto.FirstName, dto.LastName, dto.DayOfBirth, dto.RentedCar?.ToCar());
    }
}