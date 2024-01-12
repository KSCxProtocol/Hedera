using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Kar.Web3.Hedera.Pages;

public class IndexModel : HederaPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
