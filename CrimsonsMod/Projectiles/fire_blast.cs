using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class fire_blast : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("oofio");
			Main.projFrames[projectile.type] = 4;
        }

        public override void SetDefaults()
        {
			projectile.width = 128;
			projectile.height = 128;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.aiStyle = 34;
			projectile.penetrate = -1;
			projectile.timeLeft = 120;
			projectile.alpha = 255;
            projectile.light = 1f;


        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.immune[projectile.owner] = 5;
            target.AddBuff(24, 800);        //onfire  
			Main.PlaySound(SoundID.Item74, projectile.position);        
		
            for (int i = 0; i<20; i++)
            {            
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 6);   //this adds a vanilla terraria dust to the projectile
				Main.dust[dust].velocity *= 10f;
				Main.dust[dust].scale = 2f;
				Main.dust[dust].noGravity = true;
            }
			for (int i = 0; i<40; i++)
            {            
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 228);   //this adds a vanilla terraria dust to the projectile
				Main.dust[dust].velocity *= 6f;
				Main.dust[dust].scale = 0.7f;
				Main.dust[dust].noGravity = true;
            }

		}
		
        public override void Kill(int timeLeft)        
        {
			for (int i = 0; i<Main.rand.Next(30); i++)
            {
            
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 6);
				dust.noGravity = true;
				dust.scale = 3f;
                dust.velocity *= 10f;
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