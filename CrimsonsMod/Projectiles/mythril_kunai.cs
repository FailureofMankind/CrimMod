using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class mythril_kunai : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("mythril kunai");

        }

        public override void SetDefaults()
        {
			projectile.width = 22;
			projectile.height = 22;
			projectile.aiStyle = 1;
            projectile.scale = 0.6f;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.penetrate = 4;
			projectile.timeLeft = 600;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;


        }
		public override void OnHitNPC(NPC target, int damage, float knockBack, bool crit)
		{
            if(Main.rand.Next(0, 2) == 0)
            {
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-5, 5), Main.rand.Next(-5, 5), mod.ProjectileType("mythril_kunai"), projectile.damage, 0, Main.myPlayer); //Spawning a projectile                
            }
			for (int i = 0; i<Main.rand.Next(10,20); i++)
            {
            
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 157);
				dust.noGravity = true;
				dust.scale = 1.5f;
                dust.velocity *= 10f;
            }                
	    
        }

    }
}