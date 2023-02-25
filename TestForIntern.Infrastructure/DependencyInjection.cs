using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestForIntern.Logic.Interfaces;

namespace TestForIntern.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("MSSQL")));

        services.AddScoped<IAppDbContext>(provider => provider.GetService<AppDbContext>());

        services.AddScoped<IXmlSerializeService, XmlSerializeService>();

        return services;
    }
}