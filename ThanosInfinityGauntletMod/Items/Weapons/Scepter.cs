using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Items.Weapons
{
	public class Scepter : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Alien Scepter");
			Tooltip.SetDefault("The beings who created this clearly had access to a nearly \n" +
                "unbreakable and lightweight metal. \n" +
                "There is a small blue orb giving it power.");
		}

		public override void SetDefaults() 
		{
			item.damage = 162;
			item.melee = true;
			item.width = 40;
			item.height = 80;
			item.useTime = 7;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.knockBack = 5;
			item.value = 0;
			item.rare = 8;
			//item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.maxStack = 1;
            item.shoot = mod.ProjectileType("ShadowBeamClone");   //could be 302 or 526 or 242
            item.shootSpeed = 10f;
            Item.staff[item.type] = true;
        }

        /*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
        {
            float numberProjectiles = 1;
            float rotation = MathHelper.toRadians(45);
            position += Vector2.normalize(new Vector2(speedX, speedY)) * 100f;
            for(int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 1f;
                Projectile.NewProjectile(position.X, position.y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
            }
            return false;
        }*/
    }
}