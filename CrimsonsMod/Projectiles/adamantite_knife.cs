using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class adamantite_knife : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("adamantite knife");

        }

        public override void SetDefaults()
        {
			projectile.width = 22;
			projectile.height = 22;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.aiStyle = 1;
            aiType = ProjectileID.Bullet;
			projectile.penetrate = 4;
			projectile.timeLeft = 600;
            projectile.alpha = 0;			


        }
		
        public override void AI()
        {
            projectile.ai[1] += 1f;
            double degWaveyBoi = (double) projectile.ai[1]; 
            double radWaveyBoi = degWaveyBoi * (Math.PI / 180);

            projectile.position.Y -= (int)(Math.Sin(radWaveyBoi * 25) * 3);

            Dust dust = Dust.NewDustDirect(projectile.position, 0, 0, 12);
            dust.noGravity = true;
            dust.scale = 0.8f;
            dust.velocity *= 0;

        }
        
        
        
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.AddBuff(204, 1000);   
            projectile.velocity.X = Main.rand.Next(-2, 2);
            projectile.velocity.Y = Main.rand.Next(-2, 2);
        
        }
        
        public override void Kill(int timeLeft)        
        {
			for (int i = 0; i<Main.rand.Next(10,30); i++)
            {
            
				Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, 12);
				dust.noGravity = true;
				dust.scale = 2f;
                dust.velocity *= 10f;
            }                
        }
    
    
    
    }
}