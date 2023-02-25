using Microsoft.Extensions.DependencyInjection;
using TestForIntern.Logic.Interfaces;
using TestForIntern.Logic.Services;

namespace TestForIntern.Logic;

public static class DependencyInjection
{
    public static IServiceCollection AddLogic(this IServiceCollection services)
    {
        services.AddScoped<IOfferService, OfferService>();

        return services;
    }
}