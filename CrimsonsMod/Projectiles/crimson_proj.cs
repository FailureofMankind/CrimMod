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
            projectile.width = 26;
            projectile.height = 26;
            projectile.aiStyle = 1;
            aiType = ProjectileID.Bullet;
            projectile.friendly = true;
            projectile.timeLeft = 300;
            projectile.alpha = 16;			
			projectile.penetrate = -1;
			projectile.tileCollide = true;
            
		}



        public override void AI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 5);   //this adds a vanilla terraria dust to the projectile
            Main.dust[dust].noGravity = true; 
            Main.dust[dust].scale = 1.2f;
        }

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			projectile.velocity *= 0.75f;
            target.immune[projectile.owner] = 0;	
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, mod.ProjectileType("crimson_proj"), 10000, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 35);   //this adds a vanilla terraria dust to the projectile
            Main.dust[dust].noGravity = true; 
            Main.dust[dust].scale = 1.2f;
            
            		
		}
        
	}
}