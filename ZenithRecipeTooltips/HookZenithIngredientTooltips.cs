using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenithRecipeTooltips
{
    public class HookZenithIngredientTooltips : GlobalItem
    {
        private static readonly Dictionary<int, bool> RecipeItemIDs = new()
        {
            { ItemID.CopperShortsword, true },
            { ItemID.EnchantedSword, true },
            { ItemID.BeeKeeper, true },
            { ItemID.Starfury, true },
            { ItemID.Seedler, true },
            { ItemID.TheHorsemansBlade, true },
            { ItemID.InfluxWaver, true },
            { ItemID.StarWrath, true },
            { ItemID.Meowmere, true },
            { ItemID.TerraBlade, true }
        };

        private static readonly string TooltipPrefixColor = "E10643";

        private static bool IsMaterialTooltip(TooltipLine line)
        {
            return line.Name == "Material";
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (RecipeItemIDs.ContainsKey(item.type))
            {
                TooltipLine tooltip = new(Mod, "RequiredForZenith", $"[c/{TooltipPrefixColor}:Required for Zenith]");

                int materialLineIndex = tooltips.FindIndex(IsMaterialTooltip);

                // If we found the index where the "Material" tooltip is
                if (materialLineIndex > 0)
                {
                    tooltips.Insert(materialLineIndex + 1, tooltip);
                // If we didn't, just append it to the end
                } else
                {
                    tooltips.Add(tooltip);
                }
            }

            base.ModifyTooltips(item, tooltips);
        }
    }
}
