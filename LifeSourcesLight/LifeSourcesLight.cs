using Terraria.ModLoader;

namespace LifeSourcesLight
{
    public class LifeSourcesLight : Mod
    {
        public override void PostSetupContent()
        {
            base.PostSetupContent();

            // Update Main.tileLighted on post-load to ensure config is properly loaded
            LifeSourcesLightModSystem.UpdateTileLighted();
        }
    }
}