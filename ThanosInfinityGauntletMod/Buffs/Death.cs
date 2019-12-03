using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Buffs
{
	public class Death : ModBuff
	{
		public override void SetDefaults() 
		{
            DisplayName.SetDefault("Death");
            Description.SetDefault("You are being killed by a godly force.");
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
        }

		public override void Update(Player player, ref int buffIndex)
		{
            player.AddBuff(mod.BuffType("Death"), -2);
            player.lifeRegen -= 999;
		}
	}
}