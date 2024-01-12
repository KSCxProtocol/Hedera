using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Kar.Web3.Hedera.EntityFrameworkCore;

public class HederaHttpApiHostMigrationsDbContext : AbpDbContext<HederaHttpApiHostMigrationsDbContext>
{
    public HederaHttpApiHostMigrationsDbContext(DbContextOptions<HederaHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureHedera();
    }
}
