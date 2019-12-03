using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Accessories
{
	public class Aether : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Aether");
			Tooltip.SetDefault("This is a barely contained cosmic power able to slightly bend reality.\n" +
                "Negates fall damage, manipulates properties of money.");
		}

		public override void SetDefaults() 
		{
			item.accessory = true;
			item.width = 40;
            item.height = 40;
			item.value = 0;
			item.rare = 4;
            item.maxStack = 1;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.noFallDmg = true;
            //player.gravControl = true;
            player.goldRing = true;
            player.discount = true;
            player.coins = true;
        }
	}
}