using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Accessories
{
	public class Orb : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Small Gray Orb");
			Tooltip.SetDefault("This orb gives you a feeling of power.\n" +
                "Multiplies all damage by 1.5.\n" +
                "Provides a 70% chance not to consume ammo.");
		}

		public override void SetDefaults() 
		{
            item.accessory = true;
            item.width = 40;
            item.height = 40;
            item.value = 0;
            item.rare = 11;
            item.maxStack = 1;
            /*item.ammo = true;
            item.consumable = false;
            item.damage = 50;
            item.ranged = true;
            item.shoot = 88;
            item.shootSpeed = 16f;*/
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .70f;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeDamage *= 1.5f;
            player.rangedDamage *= 1.5f;
            player.magicDamage *= 1.5f;
            player.minionDamage *= 1.5f;
            player.ammoCost75 = true;
        }
    }
}