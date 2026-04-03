using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.OpenRouter.HttpClients.Registrars;
using Soenneker.OpenRouter.OpenApiClientUtil.Abstract;

namespace Soenneker.OpenRouter.OpenApiClientUtil.Registrars;

/// <summary>
/// Registers the OpenAPI client utility for dependency injection.
/// </summary>
public static class OpenRouterOpenApiClientUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="OpenRouterOpenApiClientUtil"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddOpenRouterOpenApiClientUtilAsSingleton(this IServiceCollection services)
    {
        services.AddOpenRouterOpenApiHttpClientAsSingleton()
                .TryAddSingleton<IOpenRouterOpenApiClientUtil, OpenRouterOpenApiClientUtil>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="OpenRouterOpenApiClientUtil"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddOpenRouterOpenApiClientUtilAsScoped(this IServiceCollection services)
    {
        services.AddOpenRouterOpenApiHttpClientAsSingleton()
                .TryAddScoped<IOpenRouterOpenApiClientUtil, OpenRouterOpenApiClientUtil>();

        return services;
    }
}
