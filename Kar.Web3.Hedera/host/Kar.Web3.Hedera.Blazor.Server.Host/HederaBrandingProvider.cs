using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Kar.Web3.Hedera.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class HederaBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Hedera";
}
