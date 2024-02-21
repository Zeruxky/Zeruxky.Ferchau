namespace Zeruxky.Ferchau.Persistence
{
    using Ardalis.SmartEnum;
    using Zeruxky.Ferchau.Domain;

    internal static class RentalStateDtoMapper
    {
        internal static RentalState ToRentalState(this RentalStateDto dto)
            => SmartEnum<RentalState>.FromName(dto.Name);
    }
}