using Kar.Web3.Hedera.Localization;
using Volo.Abp.Application.Services;

namespace Kar.Web3.Hedera;

public abstract class HederaAppService : ApplicationService
{
    protected HederaAppService()
    {
        LocalizationResource = typeof(HederaResource);
        ObjectMapperContext = typeof(HederaApplicationModule);
    }
}
