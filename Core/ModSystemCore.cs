namespace OreFactorization.Core;
using OreFactorization.Systems.Logistics;
using OreFactorization.Systems.Metallurgy;
using OreFactorization.Systems.Processing;
using Vintagestory.API.Common;

public class ModSystemCore : ModSystem
{
    public override void Start(ICoreAPI api)
    {
        api.Logger.Notification("[OreFactorization] Loading systems...");
        LogisticsSystem.Register(api);
        MetallurgySystem.Register(api);
        ProcessingSystem.Register(api);
        api.Logger.Notification("[OreFactorization] All systems loaded successfully.");
    }
}
