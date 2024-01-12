using Kar.Web3.Hedera.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Kar.Web3.Hedera.Pages;

public abstract class HederaPageModel : AbpPageModel
{
    protected HederaPageModel()
    {
        LocalizationResourceType = typeof(HederaResource);
    }
}
