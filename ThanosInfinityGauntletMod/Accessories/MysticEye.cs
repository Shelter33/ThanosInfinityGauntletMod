using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Accessories
{
	public class MysticEye : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mystic Eye");
			Tooltip.SetDefault("This is an eye-shaped artifact with a glowing green pupil that makes you feel uncomfortable.\n" +
                "Gives more mana and faster nights.");
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
            player.statManaMax2 += 60;
            if (!Main.dayTime)
            {
                //Main.dayRate += 100;
                Main.fastForwardTime = true;
            }
        }

        /*public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statManaMax += 100;
            if(Main.time <= 0)
            {
                Main.dayRate = 5;
            }
            
        }*/
    }
}