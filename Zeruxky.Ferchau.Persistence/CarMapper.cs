namespace Zeruxky.Ferchau.Persistence
{
    using Zeruxky.Ferchau.Domain;

    internal static class CarMapper
    {
        internal static CarDto ToDto(this Car car)
            => new()
            {
                Manufacturer = car.Manufacturer,
                ModelName = car.ModelName,
                Mileage = car.Mileage,
                RentalState = car.RentalState.ToDto(),
            };
    }
}