using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class platinum_knives_proj : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("platinum knife");

        }

        public override void SetDefaults()
        {
			projectile.width = 14;
			projectile.height = 36;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.penetrate = 5;
			projectile.timeLeft = 600;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;
            aiType = ProjectileID.Bullet; 			


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
			
			projectile.penetrate--;
			projectile.velocity *= 1.05f;
			return false;
		}        

    }
}