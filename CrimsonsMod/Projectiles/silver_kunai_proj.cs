using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class silver_kunai_proj : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("silver kunai");

        }

        public override void SetDefaults()
        {
			projectile.width = 18;
			projectile.height = 50;
			projectile.aiStyle = 1;
            projectile.scale = 0.6f;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.penetrate = 10;
			projectile.timeLeft = 600;
            projectile.alpha = 0;			


        }
		public override void OnHitNPC(NPC target, int damage, float knockBack, bool crit)
		{
            target.immune[projectile.owner] = 2;		
	    }

    }
}