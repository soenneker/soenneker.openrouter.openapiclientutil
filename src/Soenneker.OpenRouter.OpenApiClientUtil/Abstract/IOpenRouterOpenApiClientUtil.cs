using Soenneker.OpenRouter.OpenApiClient;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.OpenRouter.OpenApiClientUtil.Abstract;

/// <summary>
/// Exposes a cached OpenAPI client instance.
/// </summary>
public interface IOpenRouterOpenApiClientUtil: IDisposable, IAsyncDisposable
{
    ValueTask<OpenRouterOpenApiClient> Get(CancellationToken cancellationToken = default);
}
