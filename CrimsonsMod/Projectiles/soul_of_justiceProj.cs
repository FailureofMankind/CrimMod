using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class soul_of_justiceProj : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("Justice");

        }

        public override void SetDefaults()
        {
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 777;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;


        }

        public override void Kill(int timeLeft)
        {
            int a = Dust.NewDust(projectile.Center, projectile.width, projectile.height, 228);   //this adds a vanilla terraria dust to the projectile
            Main.dust[a].noGravity = true;  //this modify the scale of the first dust
            Main.dust[a].scale = 1.2f;
            Main.dust[a].velocity *= 4f;

        }
    }
}