namespace Zeruxky.Ferchau.Persistence
{
    using Microsoft.EntityFrameworkCore;
    using Zeruxky.Ferchau.Domain;

    internal class CarRentalRepository : ICustomerRepository
    {
        private readonly CarRentalContext context;

        public CarRentalRepository(CarRentalContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Customer customer, CancellationToken ct)
        {
            this.context.Customers.Add(customer.ToDto());
            await this.context.SaveChangesAsync(ct).ConfigureAwait(false);
        }

        public async Task UpdateAsync(Customer customer, CancellationToken ct)
        {
            this.context.Customers.Update(customer.ToDto());
            await this.context.SaveChangesAsync(ct).ConfigureAwait(false);
        }

        public IAsyncEnumerable<Customer> GetAllAsync(CancellationToken ct)
            => this.context
                .Customers
                .Select(c => c.ToCustomer())
                .AsAsyncEnumerable();

        public async Task<Customer> GetAsync(CustomerId customerId, CancellationToken ct)
        {
            var dto = await this.context
                .Customers
                .SingleAsync(c => c.Id == customerId, ct)
                .ConfigureAwait(false);

            var customer = dto.ToCustomer();
            return customer;
        }

        public Task<bool> ExistsAsync(Customer customer, CancellationToken ct)
            => this.context
                .Customers
                .ContainsAsync(customer.ToDto(), ct);
    }
}