using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class polarisBolt : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("LPolaris Bolt");

        }

        public override void SetDefaults()
        {
			projectile.width = 32;
			projectile.height = 32;
            projectile.thrown = true;
			projectile.friendly = true;
			projectile.aiStyle = 0;
			projectile.penetrate = -1;
			projectile.timeLeft = 1000;
            projectile.alpha = 255;
            projectile.tileCollide = false;	
			projectile.extraUpdates = 100;
        }
		
        public override void AI()
        {
            Dust dust1 = Dust.NewDustDirect(projectile.Center, 0, 0, 229);
            dust1.noGravity = true;
            dust1.scale = 2f;
            dust1.velocity *= 0f;
        }

        public override void Kill(int timeLeft)        
        {
			for (int i = 0; i < 10; i++)
            {
				Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, 56);
				dust.noGravity = true;
				dust.scale = 0.7f;
                dust.velocity *= 2f;
            }                
        }
    
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.immune[projectile.owner] = 0;
			Main.PlaySound(SoundID.Item74, projectile.position);        
        }
    
    }
}