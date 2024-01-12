using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Kar.Web3.Hedera;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HederaHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class HederaConsoleApiClientModule : AbpModule
{

}
