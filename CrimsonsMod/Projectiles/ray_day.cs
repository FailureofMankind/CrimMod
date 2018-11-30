using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class ray_day : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("day");

        }

        public override void SetDefaults()
        {
			projectile.width = 16;
			projectile.height = 16;
            projectile.magic = true;
			projectile.friendly = true;
			projectile.aiStyle = 0;
			projectile.penetrate = -1;
			projectile.timeLeft = 600;
            projectile.alpha = 255;
            projectile.tileCollide = true;	
			projectile.extraUpdates = 100;
        }
		
        public override void AI()
        {
            Dust dust1 = Dust.NewDustDirect(projectile.Center, 0, 0, 64);
            dust1.noGravity = true;
            dust1.scale = 2f;
            dust1.velocity *= 0f;
        }

        public override void Kill(int timeLeft)        
        {
			for (int i = 0; i < 10; i++)
            {
				Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, 64);
				dust.noGravity = true;
				dust.scale = 0.7f;
                dust.velocity *= 2f;
            }                
        }
    }
}