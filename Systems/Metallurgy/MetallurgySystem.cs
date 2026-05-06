using Vintagestory.API.Common;

namespace OreFactorization.Systems.Metallurgy;

public static class MetallurgySystem
{
    public static void Register(ICoreAPI api)
    {
        /*RegisterBlocks(api);*/
        /*RegisterItems(api);*/
        /*RegisterBlockEntities(api);*/
        /*RegisterRecipes(api);*/

        api.Logger.Notification("[Metallurgy] System registered");
    }
}
