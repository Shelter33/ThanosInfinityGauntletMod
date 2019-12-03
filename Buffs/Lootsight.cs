using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Buffs
{
	public class Lootsight : ModBuff
	{
		public override void SetDefaults() 
		{
            DisplayName.SetDefault("Lootsight");
            Description.SetDefault("You can view valuable items and enemies for a short while.");
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
        }

		public override void Update(Player player, ref int buffIndex)
		{
            player.AddBuff(mod.BuffType("Lootsight"), -5);

        }
	}
}