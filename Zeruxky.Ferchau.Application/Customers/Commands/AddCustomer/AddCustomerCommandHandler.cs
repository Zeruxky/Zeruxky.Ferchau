namespace Zeruxky.Ferchau.Application.Customers.Commands.AddCustomer
{
    using MediatR;
    using Zeruxky.Ferchau.Domain;

    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand>
    {
        private readonly ICustomerRepository customerRepository;

        public AddCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public async Task Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = request.ToCustomer();
            if (await this.customerRepository.ExistsAsync(customer, cancellationToken))
            {
                throw new InvalidOperationException("Customer already exists.");
            }
            
            await this.customerRepository.AddAsync(customer, cancellationToken);
        }
    }
}