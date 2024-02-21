namespace Zeruxky.Ferchau.Persistence
{
    using Zeruxky.Ferchau.Domain;

    internal static class CarDtoMapper
    {
        internal static Car ToCar(this CarDto dto)
            => new(dto.Manufacturer, dto.ModelName, dto.Mileage, dto.RentalState.ToRentalState());
    }
}