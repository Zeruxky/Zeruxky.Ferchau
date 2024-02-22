// <copyright file="GetCustomerCommand.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Zeruxky.Ferchau.Application.Customers.Commands.GetCustomer
{
    using MediatR;

    public record GetCustomerCommand : IRequest<CustomerDto>
    {
        public GetCustomerCommand(Guid customer)
        {
            this.Customer = customer;
        }

        public Guid Customer { get; }
    }
}