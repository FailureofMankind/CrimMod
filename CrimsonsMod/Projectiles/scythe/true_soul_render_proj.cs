using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles.scythe
{
    public class true_soul_render_proj : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("ack");

        }

        public override void SetDefaults()
        {
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 36;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 540;
            projectile.alpha = 255;			
			projectile.extraUpdates = 1;
            aiType = ProjectileID.Bullet; 			


        }

		public override void AI()
		{
			projectile.rotation += 0.2f;

            for(int i = 0; i < 5; i++)
                {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 75);   //this adds a vanilla terraria dust to the projectile
                Main.dust[dust].noGravity = true;
				
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

		public override void Kill(int timeLeft)
		{
            for(int i = 0; i < 30; i++)
                {
                Dust.NewDust(projectile.position, (int)(projectile.width / 2), (int)(projectile.height / 2), 75);   //this adds a vanilla terraria dust to the projectile
                }
		
            for(int i = 0; i < 5; i++)
                {
            		Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-2, 2), Main.rand.Next(-2, 2), 480, projectile.damage, 0, Main.myPlayer); //Spawning a projectile
				}
		}

    }
}