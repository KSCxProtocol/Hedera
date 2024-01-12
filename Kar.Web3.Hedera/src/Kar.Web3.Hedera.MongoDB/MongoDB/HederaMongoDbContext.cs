using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Kar.Web3.Hedera.MongoDB;

[ConnectionStringName(HederaDbProperties.ConnectionStringName)]
public class HederaMongoDbContext : AbpMongoDbContext, IHederaMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureHedera();
    }
}
