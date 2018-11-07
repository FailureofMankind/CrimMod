using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class icarus_lament : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("lul");

        }

        public override void SetDefaults()
        {
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.aiStyle = 0;
			projectile.penetrate = 1;
			projectile.timeLeft = 90;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;


        }
		
        public override void AI()
        {
            Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 173);
            dust.velocity *= 5f;
        }
        
        public override void Kill(int timeLeft)        
        {
            for (int i=0; i<10; i++)
            {
                int a = Dust.NewDust(projectile.position, projectile.width, projectile.height, 173);   //this adds a vanilla terraria dust to the projectile
                Main.dust[a].noGravity = true;  //this modify the scale of the first dust
                Main.dust[a].scale = 4f;
                Main.dust[a].velocity *= 10f;
            }
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-7, 2), -5, mod.ProjectileType("icarus_lament2"), projectile.damage, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-2, 7), -5, mod.ProjectileType("icarus_lament2"), projectile.damage, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
			Main.PlaySound(SoundID.Item103, projectile.position);        
        }    
    
    }
}