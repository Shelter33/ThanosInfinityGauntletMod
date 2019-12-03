using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Buffs
{
	public class Inevitable : ModBuff
	{
		public override void SetDefaults() 
		{
            DisplayName.SetDefault("Inevitable");
            Description.SetDefault("The power of the Infinity Stones is stopping you from naturally regenerating health.");
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
        }

		public override void Update(Player player, ref int buffIndex)
		{
            player.AddBuff(mod.BuffType("Inevitable"), -1);
            player.lifeRegen = 0;
		}
	}
}