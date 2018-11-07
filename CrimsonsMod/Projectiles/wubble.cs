using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class wubble : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("bubbly bubbles");

        }

        public override void SetDefaults()
        {
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 54;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 120;
			projectile.light = 0.2f;
            projectile.alpha = 128;		
            projectile.tileCollide = false;	
        }
        
        public override void AI()
        {
            Lighting.AddLight(projectile.Center, 0.9f, 0.4f, 0.4f);  //this defines the projectile light color
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 33);   //this adds a vanilla terraria dust to the projectile
            Main.dust[dust].velocity *= 0f;  //this modify the velocity of the first dust
            Main.dust[dust].scale = 2f;  //this modify the scale of the first dust
        }

    }
}