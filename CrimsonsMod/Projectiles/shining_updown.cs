using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class shining_updown : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("oofs");

        }

        public override void SetDefaults()
        {
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 120;
            projectile.alpha = 0;		
            projectile.tileCollide = false;	
			projectile.extraUpdates = 1;

        }

        public override void AI()
        {
            {         
                for (int i=0; i<5; i++)
                {
                    int a = Dust.NewDust(projectile.position, projectile.width, projectile.height, 20);   //this adds a vanilla terraria dust to the projectile
                    Main.dust[a].noGravity = true;  //this modify the scale of the first dust
                }
            }

        projectile.velocity.Y *= 1.05f;
        }
    
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.immune[projectile.owner] = 4;		
        }
        
            
    }
}