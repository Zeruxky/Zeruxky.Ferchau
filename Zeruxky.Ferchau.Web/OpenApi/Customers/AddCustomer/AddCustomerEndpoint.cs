// <copyright file="AddCustomerEndpoint.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Zeruxky.Ferchau.Web.OpenApi.Customers.AddCustomer
{
    using System.Net.Mime;
    using FastEndpoints;
    using MediatR;
    using Microsoft.AspNetCore.Http;

    public class AddCustomerEndpoint : Endpoint<AddCustomerRequest>
    {
        private readonly IMediator mediator;

        public AddCustomerEndpoint(IMediator mediator)
        {
            this.mediator = mediator;
        }

        /// <inheritdoc />
        public override void Configure()
        {
            this.AllowAnonymous();
            this.Post("/api/customers/addCustomer");
            this.Description(
                builder =>
                {
                    builder.Accepts<AddCustomerRequest>(MediaTypeNames.Application.Json);
                    builder.Produces(StatusCodes.Status204NoContent);
                    builder.ProducesProblemDetails();
                    builder.ProducesProblemFE<InternalErrorResponse>(500);
                },
                true);
            this.Summary(
                s =>
                {
                    s.Summary = "Adds a new customer.";
                    s.Responses[204] = "The customer was successfully added";
                    s.Responses[400] = "The request contains invalid or malformed data";
                    s.Responses[500] = "An unexpected error occurred while adding the customer.";
                });
            this.Options(builder => builder.WithTags("Customers"));
        }

        /// <inheritdoc />
        public override async Task HandleAsync(AddCustomerRequest req, CancellationToken ct)
        {
            await this.mediator.Send(req.ToCommand(), ct).ConfigureAwait(false);
            await this.SendNoContentAsync(ct).ConfigureAwait(false);
        }
    }
}