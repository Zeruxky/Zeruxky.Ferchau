namespace Zeruxky.Ferchau.Domain
{
    public class Customer
    {
        public Customer(string firstName, string lastName, Car? rentedCar = null)
        {
            FirstName = firstName;
            LastName = lastName;
            RentedCar = rentedCar;
        }

        public string FirstName { get; }
        
        public string LastName { get; }

        public string FullName => $"{this.FirstName} {this.LastName}";
        
        public Car? RentedCar { get; }

        public Customer RentCar(Car car) => new(this.FirstName, this.LastName, car.Rent());

        public Customer ReturnCar()
        {
            if (this.RentedCar is null)
            {
                throw new InvalidOperationException("Customer has not rented any car.");
            }

            this.RentedCar.Return();
            return new Customer(this.FirstName, this.LastName);
        }
    }
}