using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Kar.Web3.Hedera.MongoDB;

[ConnectionStringName(HederaDbProperties.ConnectionStringName)]
public interface IHederaMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
