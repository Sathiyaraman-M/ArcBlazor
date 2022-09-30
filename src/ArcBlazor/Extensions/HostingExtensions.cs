using Microsoft.Extensions.DependencyInjection;

namespace ArcBlazor.Extensions;

public static class HostingExtensions
{
    public static IServiceCollection AddArcServices(this IServiceCollection services)
    {
        return services;
    }
}