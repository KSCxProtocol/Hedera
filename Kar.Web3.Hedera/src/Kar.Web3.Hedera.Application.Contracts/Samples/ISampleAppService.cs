using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Kar.Web3.Hedera.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
