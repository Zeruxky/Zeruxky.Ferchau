// <copyright file="GetCustomerEndpoint.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Zeruxky.Ferchau.Web.OpenApi.Customers.GetCustomer
{
    using System.Net.Mime;
    using FastEndpoints;
    using MediatR;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    public class GetCustomerEndpoint : Endpoint<GetCustomerRequest, GetCustomerResponse>
    {
        private readonly IMediator mediator;

        public GetCustomerEndpoint(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public override void Configure()
        {
            this.AllowAnonymous();
            this.Get("/api/customers/getCustomer/{customerId}");
            this.Description(
                builder =>
                {
                    builder.Produces<GetCustomerResponse>(StatusCodes.Status200OK, MediaTypeNames.Application.Json);
                    builder.ProducesProblemDetails();
                    builder.ProducesProblemFE<InternalErrorResponse>(500);
                },
                true);
            this.Summary(
                s =>
                {
                    s.Summary = "Gets a already existing customer.";
                    s.Responses[200] = "The customer was successfully received";
                    s.Responses[400] = "The request contains invalid or malformed data";
                    s.Responses[500] = "An unexpected error occurred while receiving the customer.";
                });
            this.Options(builder => builder.WithTags("Customers"));
        }

        public override async Task HandleAsync(GetCustomerRequest req, CancellationToken ct)
        {
            var dto = await this.mediator.Send(req.ToCommand(), ct).ConfigureAwait(false);
            var customer = dto.ToCustomer();
            var response = new GetCustomerResponse()
            {
                Customer = customer,
            };

            await this.SendOkAsync(response, ct).ConfigureAwait(false);
        }
    }
}