using Kar.Web3.Hedera.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Kar.Web3.Hedera.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class HederaPageModel : AbpPageModel
{
    protected HederaPageModel()
    {
        LocalizationResourceType = typeof(HederaResource);
        ObjectMapperContext = typeof(HederaWebModule);
    }
}
