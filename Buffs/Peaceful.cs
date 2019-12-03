using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Buffs
{
	public class Peaceful : ModBuff
	{
		public override void SetDefaults() 
		{
            DisplayName.SetDefault("Peaceful");
            Description.SetDefault("The creatures around you are strangely friendly.");
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
        }

		public override void Update(Player player, ref int buffIndex)
		{
            player.AddBuff(mod.BuffType("Peaceful"), -3);
            /*player.npcTypeNoAggro[-55] = true;
            player.npcTypeNoAggro[-54] = true;
            player.npcTypeNoAggro[-51] = true;
            player.npcTypeNoAggro[-50] = true;
            player.npcTypeNoAggro[-49] = true;
            player.npcTypeNoAggro[-48] = true;
            player.npcTypeNoAggro[-10] = true;
            player.npcTypeNoAggro[-9] = true;
            player.npcTypeNoAggro[-8] = true;
            player.npcTypeNoAggro[-7] = true;
            player.npcTypeNoAggro[-6] = true;
            player.npcTypeNoAggro[-5] = true;
            player.npcTypeNoAggro[-4] = true;
            player.npcTypeNoAggro[-3] = true;
            player.npcTypeNoAggro[-2] = true;
            player.npcTypeNoAggro[-1] = true;*/
            player.npcTypeNoAggro[NPCID.Zombie] = true;
            player.npcTypeNoAggro[NPCID.DemonEye] = true;
            player.npcTypeNoAggro[1] = true;
            player.npcTypeNoAggro[16] = true;
            player.npcTypeNoAggro[59] = true;
            player.npcTypeNoAggro[71] = true;
            player.npcTypeNoAggro[81] = true;
            player.npcTypeNoAggro[147] = true;
            player.npcTypeNoAggro[302] = true;
            player.npcTypeNoAggro[537] = true;
            player.npcTypeNoAggro[NPCID.SlimeSpiked] = true;
            player.npcTypeNoAggro[NPCID.Crimera] = true;
            player.npcTypeNoAggro[NPCID.EaterofSouls] = true;
            player.npcTypeNoAggro[NPCID.AngryBones] = true;
            player.npcTypeNoAggro[26] = true;
            player.npcTypeNoAggro[27] = true;
            player.npcTypeNoAggro[44] = true;
            player.npcTypeNoAggro[47] = true;
            player.npcTypeNoAggro[49] = true;
            player.npcTypeNoAggro[51] = true;
            player.npcTypeNoAggro[56] = true;
            player.npcTypeNoAggro[60] = true;
            player.npcTypeNoAggro[61] = true;
            player.npcTypeNoAggro[NPCID.Mimic] = true;
            player.npcTypeNoAggro[NPCID.Gastropod] = true;
            player.npcTypeNoAggro[NPCID.Werewolf] = true;
            player.npcTypeNoAggro[109] = true;
            player.npcTypeNoAggro[NPCID.WanderingEye] = true;
            player.npcTypeNoAggro[141] = true;
            player.npcTypeNoAggro[150] = true;
            player.npcTypeNoAggro[151] = true;
            player.npcTypeNoAggro[152] = true;
            player.npcTypeNoAggro[162] = true;
            player.npcTypeNoAggro[181] = true;
            player.npcTypeNoAggro[184] = true;
            player.npcTypeNoAggro[185] = true;
            player.npcTypeNoAggro[202] = true;
            player.npcTypeNoAggro[204] = true;
            player.npcTypeNoAggro[210] = true;
            player.npcTypeNoAggro[211] = true;
            player.npcTypeNoAggro[223] = true;
            player.npcTypeNoAggro[250] = true;
            player.npcTypeNoAggro[NPCID.CursedSkull] = true;
            player.npcTypeNoAggro[469] = true;
            player.npcTypeNoAggro[NPCID.Drippler] = true;
        }
	}
}