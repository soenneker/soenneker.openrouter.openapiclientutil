using Soenneker.OpenRouter.OpenApiClientUtil.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.OpenRouter.OpenApiClientUtil.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class OpenRouterOpenApiClientUtilTests : HostedUnitTest
{
    private readonly IOpenRouterOpenApiClientUtil _openapiclientutil;

    public OpenRouterOpenApiClientUtilTests(Host host) : base(host)
    {
        _openapiclientutil = Resolve<IOpenRouterOpenApiClientUtil>(true);
    }

    [Test]
    public void Default()
    {

    }
}
