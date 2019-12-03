using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Items
{
	public class Stone4 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Stone");
			Tooltip.SetDefault("This stone sees every living being throughout the universe, as well as some other things.\n" +
                "Summons a Magic Lantern to reveal treasure.");
		}

		public override void SetDefaults() 
		{
            item.width = 40;
            item.height = 40;
            item.useTime = 30;
            item.useAnimation = 35;
            item.useStyle = 5;
            item.value = 0;
            item.rare = 3;
            item.UseSound = SoundID.Item43;
            item.buffType = 152;
            item.buffTime = 9800;
            item.maxStack = 1;
            item.noUseGraphic = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            TooltipLine line = new TooltipLine(mod, "dummy", "dummy");
            foreach (TooltipLine line2 in tooltips)
            {
                if (line2.mod == "Terraria" && line2.Name == "BuffTime")
                {
                    line = line2;
                }
            }
            if (line.Name != "dummy") tooltips.Remove(line);
        }
    }
}