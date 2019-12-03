using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Items
{
	public class Stone6 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mind Stone");
			Tooltip.SetDefault("This stone carries knowledge over everything, but trying to understand it all would kill you.\n" +
                "Weak-minded enemies become friendly for 60 seconds when used.");
		}

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.useTime = 30;
            item.useAnimation = 35;
            item.useStyle = 5;
            item.value = 0;
            item.rare = 8;
            item.UseSound = SoundID.Item43;
            item.maxStack = 1;
            item.buffType = mod.BuffType("Peaceful");
            item.buffTime = 3600;
            item.noUseGraphic = true;
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
            recipe.AddIngredient(mod.GetItem("Scepter"), 1);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}