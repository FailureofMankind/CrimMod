using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class ferrium_javelin : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("ferrium javelin");

        }

        public override void SetDefaults()
        {
			projectile.CloneDefaults(507);
			aiType = 507;            
			projectile.width = 16;
			projectile.height = 48;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 400;
            projectile.alpha = 0;		
			projectile.light = 0.7f;	
			projectile.extraUpdates = 1;


        }
		
        public override bool PreKill(int timeLeft)
		{
			projectile.type = 507;
			return true;
		}
        
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
        	Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, 296, projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
        }

                   

    }
}