using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Kar.Web3.Hedera;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(HederaDomainSharedModule)
)]
public class HederaDomainModule : AbpModule
{

}
