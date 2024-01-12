using Kar.Web3.Hedera.Samples;
using Xunit;

namespace Kar.Web3.Hedera.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<HederaMongoDbTestModule>
{

}
