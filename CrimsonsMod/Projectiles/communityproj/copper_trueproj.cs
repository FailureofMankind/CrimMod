using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles.communityproj
{
    public class copper_trueproj : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("akjfhcsgbfjkeqvaduigcvdajfhhnvafgjdkvlhbgjudiogghqbveafdjkvgiouwuhjqbvawfdsygsrj");

        }

        public override void SetDefaults()
        {
			projectile.width = 20;
			projectile.height = 64;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.aiStyle = 1;
			projectile.penetrate = 1;
			projectile.timeLeft = 800;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;


        }

        public override void Kill(int timeLeft)
        {
            for (int i=0; i<30; i++)
            {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 0);   //this adds a vanilla terraria dust to the projectile
            Main.dust[dust].noGravity = true;  //this modify the scale of the first dust
            Main.dust[dust].scale = 5f;
            }
        }
        
    }
}