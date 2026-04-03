using Soenneker.OpenRouter.OpenApiClientUtil.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.OpenRouter.OpenApiClientUtil.Tests;

[Collection("Collection")]
public sealed class OpenRouterOpenApiClientUtilTests : FixturedUnitTest
{
    private readonly IOpenRouterOpenApiClientUtil _openapiclientutil;

    public OpenRouterOpenApiClientUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _openapiclientutil = Resolve<IOpenRouterOpenApiClientUtil>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
