using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaTestMod.Projectiles
{
    public class TreeWandProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "TreeWandProjectile";
            projectile.width = 6;
            projectile.height = 6;
            projectile.timeLeft = 60;
            projectile.penetrate = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.magic = true;
            projectile.aiStyle = 8;
        }

        public override void AI()
        {
            Random rand = new Random();
            Player owner = Main.player[projectile.owner];
            projectile.alpha = 100;
            projectile.light = 0.6f;
            projectile.rotation += (float)projectile.direction * 0.2f;


            int DustID = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 6, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 120, Color.Orange, 0.75f);
            Main.dust[DustID].noGravity = false;

            Kill(projectile.timeLeft);
        }

        public override void OnHitNPC(NPC n, int damage, float knockback, bool crit)
        {
            int rand = Main.rand.Next(2);
            if (rand == 0)
            {
                n.AddBuff(24, 180);
            }
        }
    }
}