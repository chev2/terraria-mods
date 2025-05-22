using Terraria.ID;
using Terraria.ModLoader;

namespace LifeSourcesLight
{
    public class LightOverrideLifeFruit : GlobalTile
    {
        // Modify overall light brightness
        private static readonly float LifeFruitBrightCoefficient = 0.7f;

        public override void ModifyLight(int i, int j, int type, ref float r, ref float g, ref float b)
        {
            if (type == TileID.LifeFruit && LifeSourcesLightModSystem.EnableLightLifeFruit)
            {
                r = (221f / 255f) * LifeFruitBrightCoefficient;
                g = (181f / 255f) * LifeFruitBrightCoefficient;
                b = (43f / 255f) * LifeFruitBrightCoefficient;
            }
        }
    }
}
