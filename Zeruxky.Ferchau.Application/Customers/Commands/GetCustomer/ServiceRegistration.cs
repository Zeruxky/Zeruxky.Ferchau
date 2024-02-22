// <copyright file="ServiceRegistration.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Zeruxky.Ferchau.Application.Customers.Commands.GetCustomer
{
    using Microsoft.Extensions.DependencyInjection;

    internal static class ServiceRegistration
    {
        internal static IServiceCollection AddGetCustomerCommand(this IServiceCollection services)
        {
            services.AddRequestHandler<GetCustomerCommand, CustomerDto, GetCustomerCommandHandler>();
            return services;
        }
    }
}