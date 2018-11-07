using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class star_scourge : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("w o r m boi");

        }

        public override void SetDefaults()
        {
			projectile.CloneDefaults(616);
			aiType = 616;
			projectile.width = 8;
			projectile.height = 8;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 400;
            projectile.alpha = 255;			
			projectile.extraUpdates = 1;

        }
    
		public override void OnHitNPC(NPC target, int damage, float knockBack, bool crit)
		{
            target.immune[projectile.owner] = 6;

            for (int i = 0; i<30; i++)
            {            
			Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 159);
			dust.scale = 0.8f;
			dust.velocity *= 6f;
			}
	    
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