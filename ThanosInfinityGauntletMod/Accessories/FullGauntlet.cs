using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Accessories
{
	public class FullGauntlet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Infinity Gauntlet");
			Tooltip.SetDefault("A glove containing enough power to destroy the universe. It holds every Infinity Stone.");
		}

		public override void SetDefaults() 
		{
            /*item.damage = 270;
			item.melee = true;
			item.useTime = 30;
			item.useAnimation = 35;
			item.useStyle = 5;
			item.knockBack = 30;
			item.UseSound = SoundID.Item18;
			item.autoReuse = true;*/
            item.accessory = true;
            item.width = 40;
			item.height = 40;
			item.value = 99999999;
			item.rare = 5;
            item.maxStack = 1;
            //item.noUseGraphic = true;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            item.buffType = mod.BuffType("Inevitable");
            //item.buffTime = 3600;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("Gauntlet"));
            recipe.AddIngredient(mod.GetItem("Stone1"));
            recipe.AddIngredient(mod.GetItem("Stone2"));
            recipe.AddIngredient(mod.GetItem("Stone3"));
            recipe.AddIngredient(mod.GetItem("Stone4"));
            recipe.AddIngredient(mod.GetItem("Stone5"));
            recipe.AddIngredient(mod.GetItem("Stone6"));
            recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}