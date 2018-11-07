using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class gold_knives : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("gold knife");

        }

        public override void SetDefaults()
        {
			projectile.width = 14;
			projectile.height = 36;
            projectile.scale = 0.7f;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.aiStyle = 1;
            aiType = ProjectileID.Bullet;
			projectile.penetrate = 2;
			projectile.timeLeft = 600;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;


        }
		
        public override void AI()
        {
            
            projectile.ai[1] += 1f;
            double degWaveyBoi = (double) projectile.ai[1]; 
            double radWaveyBoi = degWaveyBoi * (Math.PI / 180);

            projectile.position.Y += (int)(Math.Sin(radWaveyBoi * 5) * 3);

            Dust dust = Dust.NewDustDirect(projectile.position, 0, 0, 10);
            dust.noGravity = true;
            dust.scale = 0.8f;
            dust.velocity *= 0;

        }
        
        
        
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.AddBuff(BuffID.Midas, 1000);   
			int rand = Main.rand.Next(9);
			if(rand == 0)
			{
            target.AddBuff(69, 300);   
			}
        }
    }
}