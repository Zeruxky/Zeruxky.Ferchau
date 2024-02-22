namespace Zeruxky.Ferchau.Persistence
{
    using Ardalis.SmartEnum;

    public class RentalStateDto : SmartEnum<RentalStateDto>
    {
        public static readonly RentalStateDto Rented = new(nameof(Rented), 1);

        public static readonly RentalStateDto Rentable = new(nameof(Rentable), 2);
        
        private RentalStateDto(string name, int value)
            : base(name, value)
        {
        }
    }
}