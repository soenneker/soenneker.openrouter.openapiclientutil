using Soenneker.OpenRouter.OpenApiClient;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.OpenRouter.OpenApiClientUtil.Abstract;

/// <summary>
/// Provides a cached OpenRouter API client backed by the configured HTTP provider.
/// </summary>
public interface IOpenRouterOpenApiClientUtil : IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the cached OpenRouter client, creating it on the first call.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The configured OpenRouter client.</returns>
    ValueTask<OpenRouterOpenApiClient> Get(CancellationToken cancellationToken = default);
}
