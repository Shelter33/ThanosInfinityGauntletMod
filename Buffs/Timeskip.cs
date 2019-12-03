using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Buffs
{
	public class Timeskip : ModBuff
	{
		public override void SetDefaults() 
		{
            DisplayName.SetDefault("Timeskip");
            Description.SetDefault("Night suddenly feels a lot shorter!");
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
        }

        public virtual void UpdateAccessory(Player player, bool hideVisual)

        {
            player.AddBuff(mod.BuffType("Timeskip"), -4);
            if (Main.time <= 0)
            {
                Main.dayRate = 5;
            }
        }
    }
}