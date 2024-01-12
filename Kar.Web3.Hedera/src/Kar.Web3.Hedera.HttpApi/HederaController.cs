using Kar.Web3.Hedera.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Kar.Web3.Hedera;

public abstract class HederaController : AbpControllerBase
{
    protected HederaController()
    {
        LocalizationResource = typeof(HederaResource);
    }
}
