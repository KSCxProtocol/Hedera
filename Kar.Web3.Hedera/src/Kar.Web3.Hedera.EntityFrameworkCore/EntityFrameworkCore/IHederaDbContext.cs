using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Kar.Web3.Hedera.EntityFrameworkCore;

[ConnectionStringName(HederaDbProperties.ConnectionStringName)]
public interface IHederaDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
