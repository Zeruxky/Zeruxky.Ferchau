namespace Zeruxky.Ferchau.Domain
{
    public class Customer
    {
        public Customer(CustomerId id, string firstName, string lastName, DateOnly dayOfBirth, Car? rentedCar = null)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DayOfBirth = dayOfBirth;
            this.RentedCar = rentedCar;
        }
        
        public CustomerId Id { get; }

        public string FirstName { get; }
        
        public string LastName { get; }

        public string FullName => $"{this.FirstName} {this.LastName}";
        
        public DateOnly DayOfBirth { get; }
        
        public Car? RentedCar { get; }

        public Customer RentCar(Car car) => new(this.Id, this.FirstName, this.LastName, this.DayOfBirth, car.Rent());

        public Customer ReturnCar()
        {
            if (this.RentedCar is null)
            {
                throw new InvalidOperationException("Customer has not rented any car.");
            }

            this.RentedCar.Return();
            return new Customer(this.Id, this.FirstName, this.LastName, this.DayOfBirth);
        }
    }
}