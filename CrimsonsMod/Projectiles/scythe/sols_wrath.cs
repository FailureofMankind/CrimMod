using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles.scythe
{
    public class sols_wrath : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("wrath");

        }

        public override void SetDefaults()
        {
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 80;
			projectile.light = 0.5f;
            projectile.tileCollide = false;
            projectile.alpha = 90;			
			projectile.extraUpdates = 1;
        }

        public override void AI()
        {
            Lighting.AddLight(projectile.Center, 0.9f, 0.4f, 0.4f);  //this defines the projectile light color
            
            for(int i = 0; i < 5; i++)
                {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 127);   //this adds a vanilla terraria dust to the projectile
                Main.dust[dust].velocity /= 30f;  //this modify the velocity of the first dust
                Main.dust[dust].scale = 1.3f;  //this modify the scale of the first dust
                }
            
            projectile.rotation += 1f; //this is the projectile rotation/spinning speed
            
        
        }

        public override void Kill(int timeLeft)
        {
            for(int i = 0; i < 5; i++)
                {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 127);   //this adds a vanilla terraria dust to the projectile
                Main.dust[dust].velocity /= 30f;  //this modify the velocity of the first dust
                Main.dust[dust].scale = 1.3f;  //this modify the scale of the first dust
                }
			Main.PlaySound(SoundID.Item88, projectile.position);        
        
        }

    }
}