using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class poison_piercer_proj : ModProjectile  
    { 
	    public int touch = 0;
		
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("poison piercer");

        }

        public override void SetDefaults()
        {
			projectile.width = 14;
			projectile.height = 38;
            projectile.scale = 0.7f;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.aiStyle = 1;
            aiType = ProjectileID.Bullet;
			projectile.penetrate = 5;
			projectile.timeLeft = 300;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Poisoned, 700);  
            touch = 1;			
        }
		
        public override void AI()
        {
            int c = Dust.NewDust(projectile.position, projectile.width, projectile.height, 18);
            Main.dust[c].noGravity = true;
		}
    }
}