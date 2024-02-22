// <copyright file="UpdateCustomerEndpoint.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Zeruxky.Ferchau.Web.OpenApi.Customers.UpdateCustomer
{
    using System.Net.Mime;
    using FastEndpoints;
    using MediatR;
    using Microsoft.AspNetCore.Http;
    using Zeruxky.Ferchau.Application.Customers.Commands.UpdateCustomer;

    public class UpdateCustomerEndpoint : Endpoint<UpdateCustomerRequest>
    {
        private readonly IMediator mediator;

        public UpdateCustomerEndpoint(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public override void Configure()
        {
            this.AllowAnonymous();
            this.Post("/api/customers/updateCustomer");
            this.Description(
                builder =>
                {
                    builder.Accepts<UpdateCustomerRequest>(MediaTypeNames.Application.Json);
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

        public override async Task HandleAsync(UpdateCustomerRequest req, CancellationToken ct)
        {
            await this.mediator.Send(req.ToCommand(), ct).ConfigureAwait(false);
            await this.SendNoContentAsync(ct).ConfigureAwait(false);
        }
    }

    internal static class UpdateCustomerRequestMapper
    {
        internal static UpdateCustomerCommand ToCommand(this UpdateCustomerRequest request)
            => new(request.CustomerId, request.FirstName, request.LastName, request.DayOfBirth);
    }

    public record UpdateCustomerRequest
    {
        public Guid CustomerId { get; init; } = Guid.Empty;

        public string FirstName { get; init; } = string.Empty;

        public string LastName { get; init; } = string.Empty;

        public DateOnly DayOfBirth { get; init; } = DateOnly.MinValue;
    }
}