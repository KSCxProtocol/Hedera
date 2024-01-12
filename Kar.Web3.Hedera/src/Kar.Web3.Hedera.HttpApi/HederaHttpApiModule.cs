using Localization.Resources.AbpUi;
using Kar.Web3.Hedera.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Kar.Web3.Hedera;

[DependsOn(
    typeof(HederaApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class HederaHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(HederaHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<HederaResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
