using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Items
{
	public class Stone3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Reality Stone");
			Tooltip.SetDefault("The fabric of spacetime within a few inches of the stone is bending right in front of you.\n" +
                "Let's you control gravity for a short amount of time.");
		}

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.useTime = 30;
            item.useAnimation = 35;
            item.useStyle = 5;
            item.value = 0;
            item.rare = 4;
            item.buffType = 18;       //gravitation
            item.buffTime = 3600;
            item.maxStack = 1;
            item.noUseGraphic = true;
            item.UseSound = SoundID.Item43;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            TooltipLine line = new TooltipLine(mod, "dummy", "dummy");
            foreach (TooltipLine line2 in tooltips)
            {
                if (line2.mod == "Terraria" && line2.Name == "BuffTime")
                {
                    line = line2;
                }
            }
            if (line.Name != "dummy") tooltips.Remove(line);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("Aether"), 1);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}