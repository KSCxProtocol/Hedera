using Volo.Abp.Modularity;

namespace Kar.Web3.Hedera;

[DependsOn(
    typeof(HederaDomainModule),
    typeof(HederaTestBaseModule)
)]
public class HederaDomainTestModule : AbpModule
{

}
