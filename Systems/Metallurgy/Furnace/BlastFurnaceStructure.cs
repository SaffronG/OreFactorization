using Vintagestory.API.MathTools;
using Vintagestory.API.Common;

public static class BlastFurnaceStructure
{
    public static readonly Dictionary<BlockPos, string> RequiredBlocks = new()
    {
        [new BlockPos(0,0,0)] = "controller",
        [new BlockPos(1,0,0)] = "firebrick",
        [new BlockPos(-1,0,0)] = "firebrick",
    };
    public static bool VerifyStructure(IWorldAccessor world, BlockPos controllerPosition) {
        return RequiredBlocks.All(pair =>
        {
            BlockPos checkPos = controllerPosition.AddCopy(pair.Key.X, pair.Key.Y, pair.Key.Z);
            Block placedBlock = world.BlockAccessor.GetBlock(checkPos);
            Block requiredBlock = world.GetBlock(pair.Value);
            return placedBlock?.Id == requiredBlock?.Id;
        });
    }
}
