using Terraria.ID;
using Terraria.ModLoader;

namespace LifeSourcesLight
{
    public class LightOverrideHeartCrystal : GlobalTile
    {
        // Modify overall light brightness
        private static readonly float LifeCrystalBrightCoefficient = 0.7f;

        public override void ModifyLight(int i, int j, int type, ref float r, ref float g, ref float b)
        {
            if (type == TileID.Heart && LifeSourcesLight.EnableHeartCrystalLight)
            {
                r = (255f / 255f) * LifeCrystalBrightCoefficient;
                g = (38f / 255f) * LifeCrystalBrightCoefficient;
                b = (106f / 255f) * LifeCrystalBrightCoefficient;
            }
        }
    }
}
