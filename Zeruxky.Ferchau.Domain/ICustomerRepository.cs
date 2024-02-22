namespace Zeruxky.Ferchau.Domain
{
    public interface ICustomerRepository
    {
        public Task AddAsync(Customer customer, CancellationToken ct);

        public Task UpdateAsync(Customer customer, CancellationToken ct);

        public IAsyncEnumerable<Customer> GetAllAsync(CancellationToken ct);

        public Task<Customer> GetAsync(CustomerId customerId, CancellationToken ct);

        public Task<bool> ExistsAsync(Customer customer, CancellationToken ct);
    }
}