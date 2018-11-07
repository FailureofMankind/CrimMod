using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class sun_star : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("heaven Star");

        }

        public override void SetDefaults()
        {
			projectile.width = 22;
			projectile.height = 24;
			projectile.friendly = true;
			projectile.aiStyle = 5;
			projectile.penetrate = -1;
			projectile.timeLeft = 800;
            projectile.alpha = 100;			
			projectile.extraUpdates = 1;


        }
		
        public override void Kill(int timeLeft)        
        {
            for (int i = 0; i<15; i++)
            {            
			Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 159);
			dust.scale = 2f;
			dust.velocity *= 6f;
			}
			Main.PlaySound(SoundID.Item110, projectile.position);        

        }    
    
    }
}