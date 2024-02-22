namespace Zeruxky.Ferchau.Application.Customers.Commands.GetCustomer
{
    using MediatR;
    using Zeruxky.Ferchau.Domain;

    internal class GetCustomerCommandHandler : IRequestHandler<GetCustomerCommand, CustomerDto>
    {
        private readonly ICustomerRepository customerRepository;
        
        public async Task<CustomerDto> Handle(GetCustomerCommand request, CancellationToken cancellationToken)
        {
            var customerId = new CustomerId(request.Customer);
            var customer = await this.customerRepository
                .GetAsync(customerId, cancellationToken)
                .ConfigureAwait(false);

            var dto = customer.ToDto();
            return dto;
        }
    }
}