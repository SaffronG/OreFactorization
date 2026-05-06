using Vintagestory.API.Common;

namespace OreFactorization.Systems.Processing;

public static class ProcessingSystem
{
    public static void Register(ICoreAPI api)
    {
        /*RegisterBlocks(api);*/
        /*RegisterItems(api);*/
        /*RegisterBlockEntities(api);*/
        /*RegisterRecipes(api);*/

        api.Logger.Notification("[Processing] System registered");
    }
}
