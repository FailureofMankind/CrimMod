using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
	public class crimson_proj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("crimson blast");
		}

		public override void SetDefaults()
		{
            projectile.width = 128;
            projectile.height = 128;
            projectile.aiStyle = 1;
            aiType = ProjectileID.Bullet;
            projectile.friendly = true;
            projectile.timeLeft = 10;
            projectile.alpha = 255;			
			projectile.penetrate = -1;
			projectile.tileCollide = true;
            
		}



        public override void AI()
        {
            int dust = Dust.NewDust(projectile.Center, 0, 0, 219);   //this adds a vanilla terraria dust to the projectile
            Main.dust[dust].noGravity = true; 
            Main.dust[dust].scale = 1.2f;
            Main.dust[dust].velocity *= 8f;
        }

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
            target.immune[projectile.owner] = 0;
		}
        
	}
}