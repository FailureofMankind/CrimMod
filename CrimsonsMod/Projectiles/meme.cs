using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class meme : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("eksdee");
			Main.projFrames[projectile.type] = 7;
        }

        public override void SetDefaults()
        {
			projectile.width = 64;
			projectile.height = 64;
            projectile.scale = 0.5f;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.aiStyle = 36;
            aiType = ProjectileID.Bullet;
			projectile.penetrate = -1;
			projectile.timeLeft = 3000;
            projectile.alpha = 100;			
			projectile.extraUpdates = 1;
            projectile.light = 1f;


        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.immune[projectile.owner] = 0;
            
        }
		
        public override void Kill(int timeLeft)        
        {
			for (int i = 0; i<Main.rand.Next(5, 30); i++)
            {
            
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 255);
				dust.noGravity = true;
				dust.scale = 3f;
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

		public override void AI()
		{
			projectile.scale *= 1.05f;;
		}
	
	}
}