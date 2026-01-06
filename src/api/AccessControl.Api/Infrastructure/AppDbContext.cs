using Microsoft.EntityFrameworkCore;
using AccessControl.Api.Domain;

namespace AccessControl.Api.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) {}

    public DbSet<User> Users => Set<User>();
}
