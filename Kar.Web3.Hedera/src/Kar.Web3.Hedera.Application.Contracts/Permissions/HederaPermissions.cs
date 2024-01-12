using Volo.Abp.Reflection;

namespace Kar.Web3.Hedera.Permissions;

public class HederaPermissions
{
    public const string GroupName = "Hedera";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(HederaPermissions));
    }
}
