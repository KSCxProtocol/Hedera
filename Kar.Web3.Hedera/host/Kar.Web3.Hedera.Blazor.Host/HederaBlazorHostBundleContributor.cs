using Volo.Abp.Bundling;

namespace Kar.Web3.Hedera.Blazor.Host;

public class HederaBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
