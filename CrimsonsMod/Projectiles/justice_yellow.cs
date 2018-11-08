using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class justice_yellow : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("Justice");

        }

        public override void SetDefaults()
        {
			projectile.width = 12;
			projectile.height = 26;
			projectile.aiStyle = 1;
            aiType = ProjectileID.Bullet; 			
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 180;
			projectile.light = 1f;
			projectile.extraUpdates = 1;        
    

        }
        

        public override void Kill(int timeLeft)
        {
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, mod.ProjectileType("justice_yellow_back"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
        }

    }
}