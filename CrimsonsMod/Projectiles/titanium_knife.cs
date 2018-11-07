using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class titanium_knife : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("platinum knife");

        }

        public override void SetDefaults()
        {
			projectile.width = 22;
			projectile.height = 22;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.penetrate = 4;
			projectile.timeLeft = 600;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;
            aiType = ProjectileID.Bullet; 			


        }
        
        
        public override bool OnTileCollide(Vector2 oldVelocity)
		{
            projectile.penetrate--;
			if (projectile.velocity.X != oldVelocity.X)
			{
				projectile.velocity.X = -oldVelocity.X;
			}
			if (projectile.velocity.Y != oldVelocity.Y)
			{
				projectile.velocity.Y = -oldVelocity.Y;
			}
			projectile.damage += 25;
			projectile.velocity *= 1.4f;

			for (int i = 0; i<Main.rand.Next(10,20); i++)
            {
            
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 11);
				dust.noGravity = true;
				dust.scale = 2f;
                dust.velocity *= 10f;
            }                

            return false;
		}        

    }
}