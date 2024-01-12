using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Kar.Web3.Hedera.EntityFrameworkCore;

[ConnectionStringName(HederaDbProperties.ConnectionStringName)]
public class HederaDbContext : AbpDbContext<HederaDbContext>, IHederaDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public HederaDbContext(DbContextOptions<HederaDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureHedera();
    }
}
