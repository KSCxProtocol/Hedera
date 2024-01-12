using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Kar.Web3.Hedera.Blazor.WebAssembly;

[DependsOn(
    typeof(HederaBlazorModule),
    typeof(HederaHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class HederaBlazorWebAssemblyModule : AbpModule
{

}
