using Kar.Web3.Hedera.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Kar.Web3.Hedera.Blazor.Server.Host;

public abstract class HederaComponentBase : AbpComponentBase
{
    protected HederaComponentBase()
    {
        LocalizationResource = typeof(HederaResource);
    }
}
