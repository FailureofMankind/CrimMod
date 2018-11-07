using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class shining : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("the big light");

        }

        public override void SetDefaults()
        {
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.aiStyle = 0;
			projectile.penetrate = -1;
			projectile.timeLeft = 1;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;


        }
		
        public override void AI()
        {
            {         
                for (int i=0; i<10; i++)
                {
                    int a = Dust.NewDust(projectile.position, projectile.width, projectile.height, 20);   //this adds a vanilla terraria dust to the projectile
                    Main.dust[a].noGravity = true;  //this modify the scale of the first dust
                    Main.dust[a].scale = 3f;
                    Main.dust[a].velocity *= 7f;
                }
            }
        }
        
        public override void Kill(int timeLeft)        
        {
            for (int i = 0; i < 10; i++)
            {            
                Projectile.NewProjectile(projectile.Center.X + Main.rand.Next(-200, 200), projectile.Center.Y - 1000, 0, 2, mod.ProjectileType("shining_updown"), projectile.damage, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
            }
            for (int i = 0; i < 10; i++)
            {            
                Projectile.NewProjectile(projectile.Center.X + Main.rand.Next(-200, 200), projectile.Center.Y + 1000, 0, -2, mod.ProjectileType("shining_updown"), projectile.damage, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
            }
        }    
    
    }
}