using Microsoft.Extensions.DependencyInjection;

namespace Pikot.Wintermute.Domain;

public static class ServiceRegistrations
{
    public static IServiceCollection RegisterEssentialDomainServices(this IServiceCollection services)
    {
        services.AddSingleton<IClock, Clock>();
        
        return services;
    }
}