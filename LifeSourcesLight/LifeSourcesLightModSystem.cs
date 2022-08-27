using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LifeSourcesLight
{
    public class LifeSourcesLightModSystem : ModSystem
    {
        private LifeSourcesLightConfig _configInstance;

        public LifeSourcesLightModSystem() : base()
        {
            _configInstance = ModContent.GetInstance<LifeSourcesLightConfig>();
        }

        public void ApplySettings()
        {
            LifeSourcesLight._enableHeartCrystalLight = _configInstance.EnableHeartCrystalLight;
            LifeSourcesLight._enableLifeFruitLight = _configInstance.EnableLifeFruitLight;

            Main.tileLighted[TileID.Heart] = LifeSourcesLight._enableHeartCrystalLight;
            Main.tileLighted[TileID.LifeFruit] = LifeSourcesLight._enableLifeFruitLight;
        }
    }
}
