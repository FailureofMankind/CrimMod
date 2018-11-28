using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class fire_scepter_proj : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("oofio you got blasted");

        }

        public override void SetDefaults()
        {
			projectile.width = 8;
			projectile.height = 8;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 120;
            projectile.alpha = 200;		
            projectile.extraUpdates = 10;
            projectile.tileCollide = false;
            
        }
        

		public override void OnHitNPC(NPC target, int damage, float knockBack, bool crit)
		{
		    target.AddBuff(BuffID.OnFire, 800);
        }
        public override void AI()
        {
            for (int i = 0; i<5; i++)
            {            
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 6);
				dust.noGravity = true;
				dust.scale = 1.6f;
            }
        }
        

    }
}