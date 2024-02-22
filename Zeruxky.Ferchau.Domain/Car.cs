namespace Zeruxky.Ferchau.Domain
{
    public class Car
    {
        public Car(string manufacturer, string modelName, long mileage, RentalState rentalState)
        {
            Manufacturer = manufacturer;
            ModelName = modelName;
            Mileage = mileage;
            RentalState = rentalState;
        }

        public string Manufacturer { get; }
        
        public string ModelName { get; }
        
        public long Mileage { get; }
        
        public RentalState RentalState { get; }

        public Car Rent()
        {
            if (this.RentalState == RentalState.Rented)
            {
                throw new InvalidOperationException("The car is already rented.");
            }
            
            return new Car(this.Manufacturer, this.ModelName, this.Mileage, RentalState.Rented);
        }

        public Car Return()
        {
            if (this.RentalState == RentalState.Rentable)
            {
                throw new InvalidOperationException("The car is already returned.");
            }

            return new Car(this.Manufacturer, this.ModelName, this.Mileage, RentalState.Rentable);
        }
    }
}