using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class palladium_disk : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("palladium");

        }

        public override void SetDefaults()
        {
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 3;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 600;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;
            aiType = ProjectileID.Bullet; 			


        }

        public override void AI()
        {
            int c = Dust.NewDust(projectile.position, projectile.width, projectile.height, 170);
            Main.dust[c].noGravity = true;        
            Main.dust[c].scale = 1.7f;;        
        }


        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            projectile.velocity.X = Main.rand.Next(-25, 25);
            projectile.velocity.Y = Main.rand.Next(-25, 25);
            target.immune[projectile.owner] = 4;

            if(Main.rand.Next(3)==0)
            {
            projectile.vampireHeal(damage, projectile.position);                
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