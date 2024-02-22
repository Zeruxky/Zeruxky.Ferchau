namespace Zeruxky.Ferchau.Persistence
{
    using Ardalis.SmartEnum;
    using Zeruxky.Ferchau.Domain;

    internal static class RentalStateMapper
    {
        internal static RentalStateDto ToDto(this RentalState rentalState)
            => SmartEnum<RentalStateDto>.FromName(rentalState.Name);
    }
}