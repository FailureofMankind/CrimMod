using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class vortex_tornado : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("sm0l o0fer");

        }

        public override void SetDefaults()
        {
			projectile.width = 124;
			projectile.height = 124;
            projectile.scale = 2f;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 240;
            projectile.alpha = 225;			
			projectile.extraUpdates = 1;
            projectile.light = 0.3f;

        }
		public override void AI()
		{
            projectile.ai[1] += 1f;
            double degWaveyBoi = (double) projectile.ai[1]; 
            double radWaveyBoi = degWaveyBoi * (Math.PI / 180);

            projectile.position.X -= (int)(Math.Cos(radWaveyBoi * 5) * 5);

            projectile.rotation += 0.5f;

            if(Main.rand.Next(10) == 0)
            {
            int a = Dust.NewDust(projectile.position, projectile.width, projectile.height, 230);   //this adds a vanilla terraria dust to the projectile
            Main.dust[a].noGravity = true;  //this modify the scale of the first dust
            Main.dust[a].velocity *= 0f; 
            }
        }
		public override void OnHitNPC(NPC target, int damage, float knockBack, bool crit)
		{
            target.immune[projectile.owner] = 7;	    
		}
    }
}