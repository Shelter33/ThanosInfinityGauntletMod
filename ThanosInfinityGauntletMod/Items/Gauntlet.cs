using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Items
{
	public class Gauntlet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Empty Gauntlet");
			Tooltip.SetDefault("A strange glove with large sockets on each knuckle and in the center.");
		}

		public override void SetDefaults() 
		{
			item.damage = 26;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 35;
			item.useStyle = 3;
			item.knockBack = 10;
			item.value = 0;
			item.rare = 3;
			item.UseSound = SoundID.Item18;
			item.autoReuse = true;
            item.maxStack = 1;
            item.noUseGraphic = true;
        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TitaniumBar, 30);
            recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}