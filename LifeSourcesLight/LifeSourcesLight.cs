using Terraria.ModLoader;

namespace LifeSourcesLight
{
    public class LifeSourcesLight : Mod
    {
        internal static bool _enableHeartCrystalLight;
        public static bool EnableHeartCrystalLight
        {
            get { return _enableHeartCrystalLight; }
        }

        internal static bool _enableLifeFruitLight;
        public static bool EnableLifeFruitLight
        {
            get { return _enableLifeFruitLight; }
        }

        public override void Load()
        {
            base.Load();
        }
    }
}