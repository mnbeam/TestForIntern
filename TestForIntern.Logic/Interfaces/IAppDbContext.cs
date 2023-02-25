using Microsoft.EntityFrameworkCore;
using TestForIntern.Domain.Entities;

namespace TestForIntern.Logic.Interfaces;

public interface IAppDbContext
{
    public DbSet<Offer> Offers { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}