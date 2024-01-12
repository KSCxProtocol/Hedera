using Kar.Web3.Hedera.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Kar.Web3.Hedera.Permissions;

public class HederaPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HederaPermissions.GroupName, L("Permission:Hedera"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HederaResource>(name);
    }
}
