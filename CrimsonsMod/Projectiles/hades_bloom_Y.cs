using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class hades_bloom_Y : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("bloom");

        }

        public override void SetDefaults()
        {
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.aiStyle = 0;
			projectile.penetrate = 1;
			projectile.timeLeft = 800;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;


        }
		
        public override void AI()
        {
            
            projectile.ai[1] += 1f;
            double degWaveyBoi = (double) projectile.ai[1]; 
            double radWaveyBoi = degWaveyBoi * (Math.PI / 180);

            projectile.position.Y += (int)(-1 * (Math.Sin(radWaveyBoi * 15) * 5));

            Dust dust = Dust.NewDustDirect(projectile.position, 0, 0, 218);
            dust.noGravity = true;
            dust.velocity *= 0;
            dust.scale = 1.5f;

        }
        
        public override bool OnTileCollide(Vector2 oldVelocity)
		{
			if (projectile.velocity.X != oldVelocity.X)
			{
				projectile.velocity.X = -oldVelocity.X;
			}
			if (projectile.velocity.Y != oldVelocity.Y)
			{
				projectile.velocity.Y = -oldVelocity.Y;
			}
			
			return false;
		}        
    }
}