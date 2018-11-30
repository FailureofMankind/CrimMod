using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class blast : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("oofio you got blasted lolololxdddddddd");

        }

        public override void SetDefaults()
        {
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 120;
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
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 130);   //this adds a vanilla terraria dust to the projectile
                dust.velocity *= 10f;
            }
        }
        

    }
}