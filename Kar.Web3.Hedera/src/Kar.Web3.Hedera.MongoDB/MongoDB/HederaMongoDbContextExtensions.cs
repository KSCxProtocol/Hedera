using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Kar.Web3.Hedera.MongoDB;

public static class HederaMongoDbContextExtensions
{
    public static void ConfigureHedera(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
