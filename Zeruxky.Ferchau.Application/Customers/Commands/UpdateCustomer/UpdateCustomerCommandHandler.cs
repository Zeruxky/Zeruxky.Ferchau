namespace Zeruxky.Ferchau.Application.Customers.Commands.UpdateCustomer
{
    using MediatR;
    using Zeruxky.Ferchau.Domain;

    internal class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly ICustomerRepository customerRepository;

        public UpdateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = request.ToCustomer();
            await this.customerRepository.UpdateAsync(customer, cancellationToken).ConfigureAwait(false);
        }
    }
}