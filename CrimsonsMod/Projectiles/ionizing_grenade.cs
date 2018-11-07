using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class ionizing_grenade : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("ionizing_grenade");

        }

        public override void SetDefaults()
        {
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.aiStyle = 16;
			projectile.penetrate = 1;
			projectile.timeLeft = 300;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;


        }
		
        public override void Kill(int timeLeft)
        {
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, 443, projectile.damage, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
        }

    }
}