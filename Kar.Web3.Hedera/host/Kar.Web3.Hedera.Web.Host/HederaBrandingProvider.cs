using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Kar.Web3.Hedera;

[Dependency(ReplaceServices = true)]
public class HederaBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Hedera";
}
