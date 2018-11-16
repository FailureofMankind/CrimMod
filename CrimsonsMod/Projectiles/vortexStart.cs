using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class vortexStart : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("biGg oofer");

        }

        public override void SetDefaults()
        {
			projectile.width = 62;
			projectile.height = 62;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 90;
            projectile.alpha = 255;			
			projectile.extraUpdates = 1;

        }
		public override void AI()
		{
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, mod.ProjectileType("vortex_tornado"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile                
            projectile.velocity.Y -= 1f; 
        }
        
    
    }
}