using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class cobalt_disk : ModProjectile  
    { 
        public int touch = 0;
        
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("Cobalt Disk");

        }

        public override void SetDefaults()
        {
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 3;
            projectile.scale = 0.7f;
			projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.thrown = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 800;
			projectile.light = 0.2f;
			projectile.extraUpdates = 1;   
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            touch = 1;

            target.immune[projectile.owner] = 4;
        }
        
        public override void AI()
        {
            if(touch == 1)
            {
                projectile.velocity *= 0f;
            }
            
            int c = Dust.NewDust(projectile.position, projectile.width, projectile.height, 15);
            Main.dust[c].noGravity = true;
        
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