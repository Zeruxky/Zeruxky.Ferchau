// <copyright file="UpdateCustomerCommand.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Zeruxky.Ferchau.Application.Customers.Commands.UpdateCustomer
{
    using MediatR;

    public record UpdateCustomerCommand : IRequest
    {
        public UpdateCustomerCommand(Guid customerId, string firstName, string lastName, DateOnly dayOfBirth)
        {
            this.CustomerId = customerId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DayOfBirth = dayOfBirth;
        }

        public Guid CustomerId { get; set; }

        public string FirstName { get; }
        
        public string LastName { get; }
        
        public DateOnly DayOfBirth { get; }
    }
}