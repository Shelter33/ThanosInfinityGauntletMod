using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Items.Placeable
{
	public class DwarvenBlock : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Dwarven Block");
			Tooltip.SetDefault("How... how do you have this..?");
		}

		public override void SetDefaults() 
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.useAnimation = 15;
            item.useTime = 10;
            item.useTurn = true;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 0;
			item.rare = -1;
			item.UseSound = SoundID.Item18;
			item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("DwarvenTileBlock");
        }
	}
}