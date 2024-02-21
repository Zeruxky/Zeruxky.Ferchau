namespace Zeruxky.Ferchau.Domain
{
    public class CarRental
    {
        private readonly HashSet<Customer> customers;
        private readonly HashSet<Car> cars;
        
        public CarRental(IEnumerable<Customer> customers, IEnumerable<Car> cars)
        {
            this.customers = customers.ToHashSet();
            this.cars = cars.ToHashSet();
        }

        public IReadOnlyCollection<Customer> Customers => this.customers;

        public IReadOnlyCollection<Car> Cars => this.cars;

        public Car? this[Customer customer] => this.Customers.SingleOrDefault(c => c == customer)?.RentedCar;

        public long RentedCars => this.Cars.LongCount(c => c.RentalState == RentalState.Rented);

        public void AddCustomer(Customer customer) => this.customers.Add(customer);

        public void AddCar(Car car) => this.cars.Add(car);
    }
}