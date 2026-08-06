using Fuelie.Api.Database;
using Microsoft.EntityFrameworkCore;

namespace Fuelie.Api.Configuration;

public static class DependencyInjection
{
    public static IServiceCollection AddDatabase(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<FuelieDbContext>(options =>
            options.UseNpgsql(
                configuration.GetConnectionString("DefaultConnection")));

        return services;
    }
}