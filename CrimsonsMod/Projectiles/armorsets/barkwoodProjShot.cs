using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles.armorsets
{
    public class barkwoodProjShot : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("Leaf Guardian");

        }

        public override void SetDefaults()
        {
			projectile.width = 8;
			projectile.height = 8;
            projectile.minion = true;
			projectile.friendly = true;
			projectile.aiStyle = 0;
			projectile.penetrate = -1;
			projectile.timeLeft = 1000;
            projectile.alpha = 100;			
			projectile.extraUpdates = 100;


        }
		
        public override void AI()
        {
            Dust dust1 = Dust.NewDustDirect(projectile.Center, 0, 0, 107);
            dust1.noGravity = true;
            dust1.scale = 2f;
            dust1.velocity *= 0f;
        }
        
        
        
        public override void Kill(int timeLeft)        
        {
			for (int i = 0; i < 10; i++)
            {
            
				Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, 107);
				dust.noGravity = true;
				dust.scale = 0.7f;
                dust.velocity *= 4f;
            }                
        }
    
    
    
    }
}