using GrpcApi.Server;
using Microsoft.Extensions.DependencyInjection;

namespace GrpcApi.Sdk;

public static class ServiceCollectionExtension
{
    public static void AddGrpcSdk(this IServiceCollection services)
    {
        services.AddGrpcClient<Greeter.GreeterClient>(client =>
        {
            client.Address = new Uri("https://localhost:7150");
        });

        services.AddScoped<IGreeterGrpcService, GreeterGrpcService>();
    }
}