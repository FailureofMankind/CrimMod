using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles.slayerSeries
{
    public class bone_proj : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("bone_proj");

        }

        public override void SetDefaults()
        {
			projectile.width = 14;
			projectile.height = 32;
			projectile.aiStyle = 1;
            aiType = ProjectileID.Bullet; 			
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.penetrate = 2;
			projectile.timeLeft = 400;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;


        }

		
		public override void Kill(int timeLeft)	
		{	
		Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-3, 3), Main.rand.Next(-3, 3), 117, projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f);
		}
    
	
	
	
	}
}