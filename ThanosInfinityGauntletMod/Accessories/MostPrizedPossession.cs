using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Accessories
{
	public class MostPrizedPossession : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Prized Possession");
			Tooltip.SetDefault("This is a the Collector's most prized possession. Try not to destroy it.\n" +
                "Healing is increased.");
		}

		public override void SetDefaults() 
		{
            item.accessory = true;
            item.width = 40;
            item.height = 40;
            item.value = 0;
            item.rare = 2;
            item.maxStack = 1;
        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
            recipe.anyWood = true;
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            //item.buffType = 87;
            //item.buffType = 89;
            player.lifeRegen = 3;
        }
    }
}