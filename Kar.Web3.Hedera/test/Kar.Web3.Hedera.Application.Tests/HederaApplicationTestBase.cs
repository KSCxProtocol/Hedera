using Volo.Abp.Modularity;

namespace Kar.Web3.Hedera;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class HederaApplicationTestBase<TStartupModule> : HederaTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
