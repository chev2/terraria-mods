using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LifeSourcesLight
{
    public class LifeSourcesLightModSystem : ModSystem
    {
        internal static bool _enableLightHeartCrystal = true;
        public static bool EnableLightHeartCrystal {
            get { return _enableLightHeartCrystal; }
        }

        internal static bool _enableLightLifeFruit = true;
        public static bool EnableLightLifeFruit {
            get { return _enableLightLifeFruit; }
        }

        // We use the booleans above later in an if-check, and to my knowledge,
        //  that if-check runs every tick or every frame.
        // It's more efficient than calling ModContent.GetInstance() every tick
        //  (as far as I'm aware)
        public void ApplySettings()
        {
            LifeSourcesLightConfig configInstance = ModContent.GetInstance<LifeSourcesLightConfig>();

            _enableLightHeartCrystal = configInstance.EnableHeartCrystalLight;
            _enableLightLifeFruit = configInstance.EnableLifeFruitLight;

            UpdateTileLighted();
        }

        // Modified Main.tileLighted for the heart crystal & life fruit
        // Necessary in order to enable lighting calculations for both
        public static void UpdateTileLighted() {
            Main.tileLighted[TileID.Heart] = EnableLightHeartCrystal;
            Main.tileLighted[TileID.LifeFruit] = EnableLightLifeFruit;
        }
    }
}
