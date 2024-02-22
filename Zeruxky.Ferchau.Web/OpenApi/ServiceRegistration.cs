// <copyright file="ServiceRegistration.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Zeruxky.Ferchau.Web.OpenApi
{
    using FastEndpoints;
    using Microsoft.Extensions.DependencyInjection;

    internal static class ServiceRegistration
    {
        internal static IServiceCollection AddOpenApi(this IServiceCollection services)
        {
            services.AddFastEndpoints();
            return services;
        }
    }
}