using Kar.Web3.Hedera.MongoDB;
using Kar.Web3.Hedera.Samples;
using Xunit;

namespace Kar.Web3.Hedera.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<HederaMongoDbTestModule>
{

}
