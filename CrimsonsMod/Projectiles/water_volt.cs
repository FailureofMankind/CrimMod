using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class water_volt : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
		    DisplayName.SetDefault("bigoof");
        }

        public override void SetDefaults()
        {
		    projectile.aiStyle = 0;
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = 5;		
            projectile.light = 1f;
			projectile.tileCollide = true;
        }    
		
		public override void AI()
		{
			int a = Dust.NewDust(projectile.Center, 0,  0, 230);
			Main.dust[a].noGravity = true;  //this modify the scale of the first dust
			Main.dust[a].scale = 2f;
			Main.dust[a].velocity *= 0f;

		}

        public override bool OnTileCollide(Vector2 oldVelocity)
		{
            projectile.penetrate--;
			if (projectile.velocity.X != oldVelocity.X)
			{
				projectile.velocity.X = -oldVelocity.X;
			}
			if (projectile.velocity.Y != oldVelocity.Y)
			{
				projectile.velocity.Y = -oldVelocity.Y;
			}
			projectile.velocity *= 1.1f;

			return false;
		}        
    }
}