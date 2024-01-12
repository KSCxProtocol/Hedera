using Volo.Abp.Modularity;

namespace Kar.Web3.Hedera;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class HederaDomainTestBase<TStartupModule> : HederaTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
