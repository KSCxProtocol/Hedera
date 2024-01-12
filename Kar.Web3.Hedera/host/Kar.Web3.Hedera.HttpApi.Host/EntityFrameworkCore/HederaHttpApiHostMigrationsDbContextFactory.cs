using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Kar.Web3.Hedera.EntityFrameworkCore;

public class HederaHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<HederaHttpApiHostMigrationsDbContext>
{
    public HederaHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<HederaHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Hedera"));

        return new HederaHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
