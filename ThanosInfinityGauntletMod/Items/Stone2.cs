using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Items
{
	public class Stone2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Space Stone");
			Tooltip.SetDefault("A blue stone that controls space and matter.\n" +
                "Click anywhere to teleport.");
		}

		public override void SetDefaults() 
		{
            item.width = 40;
            item.height = 40;
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = 5;
            item.value = 0;
            item.rare = 1;
            item.UseSound = SoundID.Item43;
            //item.discordRod;
            item.maxStack = 1;
            item.noUseGraphic = true;
        }

        public override bool UseItem(Player player)
        {
            if (Main.myPlayer == player.whoAmI && player.itemAnimation > 0 && player.itemTime == 0)
            {
                player.itemTime = item.useTime;
                Vector2 vector31;
                vector31.X = (float)Main.mouseX + Main.screenPosition.X;
                if (player.gravDir == 1f)
                {
                    vector31.Y = (float)Main.mouseY + Main.screenPosition.Y - (float)player.height;
                }
                else
                {
                    vector31.Y = Main.screenPosition.Y + (float)Main.screenHeight - (float)Main.mouseY;
                }
                vector31.X -= (float)(player.width / 2);
                if (vector31.X > 50f && vector31.X < (float)(Main.maxTilesX * 16 - 50) && vector31.Y > 50f && vector31.Y < (float)(Main.maxTilesY * 16 - 50))
                {
                    int num275 = (int)(vector31.X / 16f);
                    int num276 = (int)(vector31.Y / 16f);
                    if ((Main.tile[num275, num276].wall != 87 || (double)num276 <= Main.worldSurface || NPC.downedPlantBoss) && !Collision.SolidCollision(vector31, player.width, player.height))
                    {
                        player.Teleport(vector31, 1, 0);
                        NetMessage.SendData(65, -1, -1, null, 0, (float)player.whoAmI, vector31.X, vector31.Y, 1, 0, 0);
                        if (player.chaosState)
                        {
                            player.statLife -= player.statLifeMax2 / 7;
                            PlayerDeathReason damageSource = PlayerDeathReason.ByOther(13);
                            if (Main.rand.Next(2) == 0)
                            {
                                damageSource = PlayerDeathReason.ByOther(player.Male ? 14 : 15);
                            }
                            if (player.statLife <= 0)
                            {
                                player.KillMe(damageSource, 1.0, 0, false);
                            }
                            player.lifeRegenCount = 0;
                            player.lifeRegenTime = 0;
                        }
                        //player.AddBuff(88, 360, true);
                    }
                }
            }
            return true;
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

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("Tesseract"), 1);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}