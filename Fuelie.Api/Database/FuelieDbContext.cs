using Microsoft.EntityFrameworkCore;

namespace Fuelie.Api.Database;

public class FuelieDbContext : DbContext
{
    public FuelieDbContext(DbContextOptions<FuelieDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
}