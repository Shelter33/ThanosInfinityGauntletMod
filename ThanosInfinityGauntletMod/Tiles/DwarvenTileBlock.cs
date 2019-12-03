using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ThanosInfinityGauntletMod.Tiles
{
	public class DwarvenTileBlock : ModTile
	{
		public override void SetDefaults() 
		{
            Main.tileSolid[Type] = true;
            mineResist = 99999f;
            minPick = 99999;
            soundType = 21;
            soundStyle = 2;
            Main.tileMergeDirt[Type] = true;
            //Main.tileBlockLight[Type] = true; //emits light
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("DwarvenBlock"); //tile drop
            AddMapEntry(new Color(114, 114, 114));
		}

		/*public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) 
		{
            r = 0.5f;
            g = 0.5f;
            b = 0.5f;
        }*/
	}
}