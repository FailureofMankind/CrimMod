using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class dry_bolt : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("dry bolt");

        }

        public override void SetDefaults()
        {
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 800;
            projectile.alpha = 256;			
			projectile.extraUpdates = 1;
            projectile.light = 0.6f;


        }
        
        public override void AI()
        {
            for (int i = 0; i<5; i++)
            {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 61);   //this adds a vanilla terraria dust to the projectile
            Main.dust[dust].velocity /= 50f;  //this modify the velocity of the first dust
            Main.dust[dust].scale = 1.2f;  //this modify the scale of the first dust
            Main.dust[dust].noGravity = true;  //this modify the scale of the first dust
            }
        }
        
        
        
        public override bool OnTileCollide(Vector2 oldVelocity)
		{
			if (projectile.velocity.X != oldVelocity.X)
			{
				projectile.velocity.X = -oldVelocity.X;
			}
			if (projectile.velocity.Y != oldVelocity.Y)
			{
				projectile.velocity.Y = -oldVelocity.Y;
			}
			
			return false;
		}        

    }
}