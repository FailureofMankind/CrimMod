using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class mana_dagger : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("mana dagger");

        }

        public override void SetDefaults()
        {
			projectile.CloneDefaults(48);
			aiType = 48;
			projectile.width = 22;
			projectile.height = 36;
            projectile.scale = 0.6f;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = 3;
			projectile.timeLeft = 180;
            projectile.alpha = 100;			
			projectile.extraUpdates = 0;
            projectile.light = 0.3f;


        }
		
        
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
			for (int i = 0; i<Main.rand.Next(12, 30); i++)
            {
            
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 20);
				dust.noGravity = true;
				dust.scale = 0.6f;
				dust.velocity *= 4f;
            }                

        }

        public override void Kill(int timeLeft)        
        {
			for (int i = 0; i<Main.rand.Next(2, 8); i++)
            {
            
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 20);
				dust.noGravity = true;
				dust.scale = 1.6f;
            }                
        }
    }
}