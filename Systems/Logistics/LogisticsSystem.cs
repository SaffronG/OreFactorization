using Vintagestory.API.Common;

namespace OreFactorization.Systems.Logistics;

public static class LogisticsSystem
{
    public static void Register(ICoreAPI api)
    {
        /*RegisterBlocks(api);*/
        /*RegisterItems(api);*/
        /*RegisterBlockEntities(api);*/
        /*RegisterRecipes(api);*/

        api.Logger.Notification("[Logistics] System registered");
    }
}
