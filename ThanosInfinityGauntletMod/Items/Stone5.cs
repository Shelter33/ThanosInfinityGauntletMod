using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Items
{
	public class Stone5 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Time Stone");
			Tooltip.SetDefault("The longer you look at it, the less understanding you have of the concept of time.");
		}

		public override void SetDefaults() 
		{
            item.width = 40;
            item.height = 40;
            item.useTime = 30;
            item.useAnimation = 35;
            item.useStyle = 5;
            item.value = 0;
            item.rare = 2;
            item.UseSound = SoundID.Item43;
            //Main.fastForwardTime = true; make happen only when used
            item.maxStack = 1;
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
            recipe.AddIngredient(mod.GetItem("MysticEye"), 1);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}