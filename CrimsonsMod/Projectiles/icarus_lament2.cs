using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class icarus_lament2 : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("owo");

        }

        public override void SetDefaults()
        {
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.aiStyle = 1;
			projectile.penetrate = 3;
			projectile.timeLeft = 240;
            projectile.alpha = 0;			
			projectile.tileCollide = false;


        }
		
        public override void AI()
        {
            Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 173);
            dust.noGravity = true;
            dust.velocity *= 0f;
            dust.scale = 3f;
        }
        
    
    }
}