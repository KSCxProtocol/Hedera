using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Kar.Web3.Hedera;

[DependsOn(
    typeof(HederaApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class HederaHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(HederaApplicationContractsModule).Assembly,
            HederaRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<HederaHttpApiClientModule>();
        });

    }
}
