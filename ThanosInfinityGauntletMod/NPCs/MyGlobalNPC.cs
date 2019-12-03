using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.NPCs
{
    public class MyGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.MoonLordCore)
            {
                if (Main.rand.NextFloat() < .0025f)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("Tesseract"));
                }
            }
        }
    }
}
