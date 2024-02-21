namespace Zeruxky.Ferchau.Domain
{
    public record CarRentalEntry
    {
        public CarRentalEntry(Customer customer, Car car, long mileageConsumption)
        {
            this.Customer = customer;
            this.Car = car;
            this.MileageConsumption = mileageConsumption;
        }

        public Customer Customer { get; }
        
        public Car Car { get; }
        
        public long MileageConsumption { get; }
    }
}