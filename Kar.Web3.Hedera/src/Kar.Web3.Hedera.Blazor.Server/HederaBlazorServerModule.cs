using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Kar.Web3.Hedera.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(HederaBlazorModule)
    )]
public class HederaBlazorServerModule : AbpModule
{

}
