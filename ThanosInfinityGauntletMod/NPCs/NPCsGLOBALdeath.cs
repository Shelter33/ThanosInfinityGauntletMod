/*using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.NPCs
{
    public class NPCsGLOBALdeath : GlobalNPC
    {
        public override void ResetEffects(NPCs npc)
        {
            npc.GetModInfo<NPCsINFOdeath>(mod).customdebuff = false;
        }

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (npc.GetModInfo<NPCsINFOdeath>(mod).customdebuff)
            {
                npc.lifeRegen -= 999;
                if(damage < 2)
                {
                    damage = 4;
                }
            }
        }
    }
}*/