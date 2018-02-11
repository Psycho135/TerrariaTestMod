using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaTestMod.Projectiles
{

    public class SunSwordProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "A sword of light";  
            projectile.width = 36;       
            projectile.height = 36;  
            projectile.friendly = true;      
            projectile.melee = true;        
            projectile.tileCollide = true; 
            projectile.penetrate = 2;      
            projectile.timeLeft = 200;   
            projectile.light = 0.75f;   
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }
        public override void AI()           
        {                                                           
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }
    }
}