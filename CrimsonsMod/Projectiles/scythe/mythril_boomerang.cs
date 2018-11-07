using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles.scythe
{
    public class mythril_boomerang : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("oofio you got blasted lolololxdddddddd");

        }

        public override void SetDefaults()
        {
			projectile.CloneDefaults(52);
			aiType = 52;
			projectile.width = 27;
			projectile.height = 48;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 1000;
            projectile.alpha = 100;		
            projectile.extraUpdates = 1;
            projectile.tileCollide = false;
            
        }
        
		public override void OnHitNPC(NPC target, int damage, float knockBack, bool crit)
		{
            for (int i = 0; i<20; i++)
            {            
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 61);   //this adds a vanilla terraria dust to the projectile
				Main.dust[dust].velocity *= 5f;
				Main.dust[dust].scale = 2f;
            }
        }

    }
}