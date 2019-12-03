using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThanosInfinityGauntletMod.Projectiles
{
    public class ShadowBeamClone : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 4;
            projectile.height = 4;
            //projectile.aiStyle = 48;
            projectile.friendly = true;
            //projectile.magic = true;
            projectile.extraUpdates = 100;
            projectile.timeLeft = 400;
            projectile.penetrate = 2;
            projectile.light = 0.55f;
        }

        public override string Texture { get { return "Terraria/Projectile_" + ProjectileID.ShadowBeamHostile; } }

        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            projectile.damage = (int)(projectile.damage * 1.2);
        }

        public override void AI()
        {
            projectile.localAI[0] += 1f;
            if (projectile.localAI[0] > 9f)
            {
                for (int i = 0; i < 4; i++)
                {
                    Vector2 projectilePosition = projectile.position;
                    projectilePosition -= projectile.velocity * ((float)i * 0.25f);
                    projectile.alpha = 255;
                    int dust = Dust.NewDust(projectilePosition, 1, 1, 178, 0f, 0f, 0, default(Color), 1f);
                    Main.dust[dust].noGravity = true;
                    Main.dust[dust].position = projectilePosition;
                    Main.dust[dust].scale = (float)Main.rand.Next(70, 110) * 0.013f;
                    Main.dust[dust].velocity *= 0.2f;
                }
            }
        }
    }
}
