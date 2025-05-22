using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace LifeSourcesLight
{
    public class LifeSourcesLightConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [LabelKey("$Mods.LifeSourcesLight.Configs.Common.EnableHeartCrystalLight.Label")]
		[TooltipKey("$Mods.LifeSourcesLight.Configs.Common.EnableHeartCrystalLight.Tooltip")]
        [DefaultValue(true)]
        public bool EnableHeartCrystalLight { get; set; }

        [LabelKey("$Mods.LifeSourcesLight.Configs.Common.EnableLifeFruitLight.Label")]
		[TooltipKey("$Mods.LifeSourcesLight.Configs.Common.EnableLifeFruitLight.Tooltip")]
        [DefaultValue(true)]
        public bool EnableLifeFruitLight { get; set; }

        public override void OnChanged()
        {
            ModContent.GetInstance<LifeSourcesLightModSystem>()?.ApplySettings();
        }
    }
}
