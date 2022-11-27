using Microsoft.EntityFrameworkCore;
using sattec.Identity.Domain.Entities;

namespace sattec.Identity.Application.Common.Interfaces;

public interface IApplicationDbContext
{
 //   DbSet<User> User { get; }
     DbSet<BankAccount> BankAccounts { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
