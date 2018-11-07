using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class bauxite_proj : ModProjectile  
    { 
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("bauxite");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(604);
			aiType = 604;
            projectile.width = 16;
            projectile.height = 16;
            projectile.friendly = true;
            projectile.timeLeft = 800;
            projectile.alpha = 164;			
			projectile.penetrate = -1;
			projectile.tileCollide = false;
            projectile.light = 0.7f;
            
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = 604;
			return true;
		}
		public override void PostAI()
		{
			if (Main.rand.Next(2) == 0)
			{
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 20);
				dust.noGravity = true;
				dust.scale = 1.6f;
	        }
	    }
        
    }

}