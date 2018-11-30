using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class anhydrous_stars : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("anhydrous star");

        }

        public override void SetDefaults()
        {
			projectile.width = 22;
			projectile.height = 22;
            projectile.scale = 0.7f;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.aiStyle = 14;
			projectile.penetrate = 4;
			projectile.timeLeft = 400;
            projectile.alpha = 0;			


        }

        public override void Kill(int timeLeft)
        {
            for (int i=0; i<10; i++)
            {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 116);   //this adds a vanilla terraria dust to the projectile
            Main.dust[dust].noGravity = true;  //this modify the scale of the first dust
            Main.dust[dust].scale = 1.8f;
            }
        }
        
    }
}