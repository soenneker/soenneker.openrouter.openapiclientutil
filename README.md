[![](https://img.shields.io/nuget/v/soenneker.openrouter.openapiclientutil.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openrouter.openapiclientutil/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.openrouter.openapiclientutil/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.openrouter.openapiclientutil/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.openrouter.openapiclientutil.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openrouter.openapiclientutil/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.openrouter.openapiclientutil/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.openrouter.openapiclientutil/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.OpenRouter.OpenApiClientUtil

Provides a configured OpenRouter API client and reuses it for the lifetime of the registered service.

## Installation

```bash
dotnet add package Soenneker.OpenRouter.OpenApiClientUtil
```

## Configuration

```json
{
  "OpenRouter": {
    "ApiKey": "your-api-key"
  }
}
```

## Usage

```csharp
using Soenneker.OpenRouter.OpenApiClientUtil.Abstract;
using Soenneker.OpenRouter.OpenApiClientUtil.Registrars;

services.AddOpenRouterOpenApiClientUtilAsSingleton();

IOpenRouterOpenApiClientUtil openRouter = serviceProvider
    .GetRequiredService<IOpenRouterOpenApiClientUtil>();

var client = await openRouter.Get(cancellationToken);
var models = await client.Models.GetAsync(cancellationToken: cancellationToken);
```

Use `AddOpenRouterOpenApiClientUtilAsScoped()` when each application scope should have its own generated client wrapper. The underlying authenticated HTTP provider remains shared and is disposed by the service container at shutdown.
