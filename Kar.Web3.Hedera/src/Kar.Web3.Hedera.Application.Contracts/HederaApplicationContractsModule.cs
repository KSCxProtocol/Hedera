using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Kar.Web3.Hedera;

[DependsOn(
    typeof(HederaDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class HederaApplicationContractsModule : AbpModule
{

}
