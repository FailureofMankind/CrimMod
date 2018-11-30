using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class dagger_explosion : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("oofio you got blasted lolololxdddddddd");

        }

        public override void SetDefaults()
        {
			projectile.width = 128;
			projectile.height = 128;
            projectile.scale = 2f;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 30;
            projectile.alpha = 256;		
            projectile.tileCollide = false;
            
        }
        

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.immune[projectile.owner] = 0;
        }
        public override void AI()
        {
            for (int i = 0; i<50; i++)
            {            
                int c = Dust.NewDust(projectile.position, projectile.width, projectile.height, 20);   //this adds a vanilla terraria dust to the projectile
                Main.dust[c].noGravity = true;  //this modify the scale of the first dust
                Main.dust[c].scale = 2f;
                Main.dust[c].velocity *= 10f;
            }
        }
    }
}