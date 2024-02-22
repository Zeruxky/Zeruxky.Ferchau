namespace Zeruxky.Ferchau.Domain
{
    using Ardalis.SmartEnum;

    public class RentalState : SmartEnum<RentalState>
    {
        public static readonly RentalState Rented = new(nameof(Rented), 1);

        public static readonly RentalState Rentable = new(nameof(Rentable), 2);
        
        private RentalState(string name, int value)
            : base(name, value)
        {
        }
    }
}