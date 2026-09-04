using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Extensions.ValueTask;
using Soenneker.OpenRouter.HttpClients.Abstract;
using Soenneker.OpenRouter.OpenApiClient;
using Soenneker.OpenRouter.OpenApiClientUtil.Abstract;
using Soenneker.Utils.AsyncSingleton;

namespace Soenneker.OpenRouter.OpenApiClientUtil;

/// <inheritdoc cref="IOpenRouterOpenApiClientUtil" />
public sealed class OpenRouterOpenApiClientUtil : IOpenRouterOpenApiClientUtil
{
    private readonly AsyncSingleton<OpenRouterOpenApiClient> _client;

    public OpenRouterOpenApiClientUtil(IOpenRouterOpenApiHttpClient httpClientUtil)
    {
        _client = new AsyncSingleton<OpenRouterOpenApiClient>(async token =>
        {
            HttpClient httpClient = await httpClientUtil.Get(token).NoSync();

            var requestAdapter = new HttpClientRequestAdapter(new AnonymousAuthenticationProvider(), httpClient: httpClient);

            return new OpenRouterOpenApiClient(requestAdapter);
        });
    }

    public ValueTask<OpenRouterOpenApiClient> Get(CancellationToken cancellationToken = default)
    {
        return _client.Get(cancellationToken);
    }

    public void Dispose()
    {
        _client.Dispose();
    }

    public ValueTask DisposeAsync()
    {
        return _client.DisposeAsync();
    }
}
