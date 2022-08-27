using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace LifeSourcesLight
{
    [Label("Config")]
    public class LifeSourcesLightConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [DefaultValue(true)]
        [Label("Enable Lighting for Heart Crystal")]
        [Tooltip("Whether or not to enable lighting for the Heart Crystal.")]
        public bool EnableHeartCrystalLight { get; set; }

        [DefaultValue(true)]
        [Label("Enable Lighting for Life Fruit")]
        [Tooltip("Whether or not to enable lighting for the Life Fruit.")]
        public bool EnableLifeFruitLight { get; set; }

        public override void OnChanged()
        {
            ModContent.GetInstance<LifeSourcesLightModSystem>()?.ApplySettings();
        }
    }
}
