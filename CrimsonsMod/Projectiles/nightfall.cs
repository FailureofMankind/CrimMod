using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class nightfall : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("nightfall");

        }

        public override void SetDefaults()
        {
			projectile.width = 8;
			projectile.height = 8;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 600;
            projectile.alpha = 255;			
			projectile.extraUpdates = 5;


        }
        public override void AI()
        {
			for (int i = 0; i<Main.rand.Next(20); i++)
            {
            Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 62);
            dust.noGravity = true;
            dust.scale = 1.5f;
            }
        }

		public override void OnHitNPC(NPC target, int damage, float knockBack, bool crit)
		{
			for (int i = 0; i<Main.rand.Next(10,20); i++)
            {
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 62);
				dust.noGravity = true;
				dust.scale = 2f;
                dust.velocity *= 4f;
            }                
	    
        }

        public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.NPCDeath24, projectile.position);
			for (int i = 0; i<Main.rand.Next(10,20); i++)
            {
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 62);
				dust.noGravity = true;
				dust.scale = 2f;
                dust.velocity *= projectile.velocity;
            }                
        }
   
    }

}