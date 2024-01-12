using Volo.Abp.Modularity;

namespace Kar.Web3.Hedera;

[DependsOn(
    typeof(HederaApplicationModule),
    typeof(HederaDomainTestModule)
    )]
public class HederaApplicationTestModule : AbpModule
{

}
