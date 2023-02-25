using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TestForIntern.Domain.Entities;
using TestForIntern.Logic.Interfaces;

namespace TestForIntern.Infrastructure;

internal class AppDbContext : DbContext, IAppDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Offer> Offers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}