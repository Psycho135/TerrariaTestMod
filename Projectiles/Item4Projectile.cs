using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaTestMod.Projectiles
{
    public class Item4Projectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "Cool Proj";
            projectile.width = 60;
            projectile.height = 60;
            projectile.friendly = true;
            projectile.penetrate = -1;                       
            Main.projFrames[projectile.type] = 4;           
            projectile.hostile = false;
            projectile.magic = true;                        
            projectile.tileCollide = true;                 
            projectile.ignoreWater = true;
        }

        public override void AI()
        {

               int DustID2 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width + 2, projectile.height + 2, mod.DustType("DustName"), projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 20, default(Color), 2.9f);
               Main.dust[DustID2].noGravity = true;

            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;
            projectile.alpha = (int)projectile.localAI[0] * 2;
            
            if (projectile.localAI[0] > 130f) 
            {
                projectile.Kill();
            }

        }
        public override bool PreDraw(SpriteBatch sb, Color lightColor)
        {
            projectile.frameCounter++; 
            if (projectile.frameCounter >= 10) 
            {
                projectile.frame++; 
                projectile.frameCounter = 0; 
                if (projectile.frame > 3) 
                    projectile.frame = 0; 
            }
            return true;
        }
    }
}