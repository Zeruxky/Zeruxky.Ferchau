namespace Zeruxky.Ferchau.Application
{
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;

    internal static class MediatrRegistrator
    {
        internal static IServiceCollection AddRequestHandler<TRequest, THandler>(this IServiceCollection services)
            where TRequest : class, IRequest
            where THandler : class, IRequestHandler<TRequest>
        {
            services.AddTransient<IRequest, TRequest>();
            services.AddTransient<IRequestHandler<TRequest>, THandler>();
            return services;
        }

        internal static IServiceCollection AddRequestHandler<TRequest, TResponse, THandler>(
            this IServiceCollection services)
            where TRequest : class, IRequest<TResponse>
            where THandler : class, IRequestHandler<TRequest, TResponse>
        {
            services.AddTransient<IRequest<TResponse>, TRequest>();
            services.AddTransient<IRequestHandler<TRequest, TResponse>, THandler>();
            return services;
        }
    }
}