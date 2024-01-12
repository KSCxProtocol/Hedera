using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Kar.Web3.Hedera;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class HederaInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<HederaInstallerModule>();
        });
    }
}
