using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Accessories
{
    [AutoloadEquip(EquipType.Wings)]
    public class Tesseract : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Tesseract");
			Tooltip.SetDefault("A glowing blue cube that is perfectly smooth.\n" +
                "Allows flight and slow fall, and increases movement speed. Mining speed is increased.");
		}

		public override void SetDefaults() 
		{
            item.accessory = true;
            item.width = 40;
            item.height = 40;
            item.value = 0;
            item.rare = 4;
            item.maxStack = 1;
            //item.UseSound = SoundID.Item7;
        }

        public bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Wings);
            return true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 200;
            player.moveSpeed += 1.15f;
            //player.carpet = true;
            //player.noFallDmg = false;
            player.pickSpeed += 1f;
            //player.slowFall = false;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 1f;      //originally 9f
            ascentWhenRising = 0.35f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 3f;
            constantAscend = 0.135f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 10f;
            acceleration *= 3f;
        }

        /*public override void UpdateAccessory(Player player, bool hideVisual)
        {
            //item.canFly = true;
            if (KeyCode == Keys.r)
            {
                player.teleportationPotion; //give ability to randomly teleport with button
            }*/

            /*private override void buttonTest_r(object sender, EventArgs e)
             {
                  player.teleportationPotion; //give ability to randomly teleport with button
             }

             private void textBoxTest_Keyr(object sender, KeyEventArgs e)
             {
                 if (e.KeyCode == Keys.r)
                 {
                     buttonTest_r(this, new EventArgs());
                 }
             }
        }*/
    }
}