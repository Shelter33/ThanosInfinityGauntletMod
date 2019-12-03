using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Items
{
	public class Stone1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Power Stone");
			Tooltip.SetDefault("This small purple rock waits for its chance to destroy a life form.\n" +
                "It would not be wise to use this.");
		}

		public override void SetDefaults() 
		{
            item.width = 40;
            item.height = 40;
            item.useTime = 30;
            item.useAnimation = 35;
            item.useStyle = 5;
            //item.knockBack = 30;
            item.value = 0;
            item.rare = 11;
            item.UseSound = SoundID.Item43;
            item.maxStack = 1;
            item.buffType = mod.BuffType("Death");
            item.buffTime = 3600;
            item.noUseGraphic = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            //need a dummy because you can't remove elements from a list while you are iterating
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

    /*public virtual void UpdateBadLifeRegen(Player player, bool hideVisual)
    {
        player.lifeRegen = 0;
        player.lifeRegenTime = 0;
    }*/

    public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("Orb"), 1);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}