using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Kar.Web3.Hedera.Web.Menus;

public class HederaMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(HederaMenus.Prefix, displayName: "Hedera", "~/Hedera", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
