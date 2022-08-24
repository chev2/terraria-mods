using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace LifeSourcesLight
{
	public class LifeSourcesLight : Mod
	{
        public override void Load()
        {
            Main.tileLighted[TileID.Heart] = true;
            Main.tileLighted[TileID.LifeFruit] = true;

            base.Load();
        }
    }
}