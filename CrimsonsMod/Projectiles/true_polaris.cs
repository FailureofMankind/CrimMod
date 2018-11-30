using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class true_polaris : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("true polaris");

        }

        public override void SetDefaults()
        {
			projectile.width = 64;
			projectile.height = 64;
			projectile.friendly = true;
            projectile.aiStyle = 0;
			projectile.tileCollide = false;
			projectile.thrown = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 260;
			projectile.light = 0.5f;
            projectile.alpha = 64;
			projectile.extraUpdates = 0;   
        }

        int count = 0;
        public override void AI()
        {
            Player player = Main.player[projectile.owner];

            projectile.rotation += 3;
            count++;
            if(count > (projectile.timeLeft / 5)) 
            {
                Vector2 velocityShoot = player.Center - projectile.Center;
                float magnitude = Magnitude(velocityShoot);

                if(magnitude > 60)
                {
                    velocityShoot *= 50f / magnitude;
                    projectile.velocity = velocityShoot;
                }
                else
                {
                    projectile.penetrate = 0;
                }
                        
				Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, 56);
				dust.noGravity = true;
                dust.velocity *= 3f;                
            }
        }
        private float Magnitude(Vector2 m)
        {
            return (float)Math.Sqrt(m.X * m.X + m.Y * m.Y);
        }

        int countProj = 0;
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.immune[projectile.owner] = 0;

            Projectile.NewProjectile(target.Center.X, target.Center.Y, Main.rand.Next(-5, 5), Main.rand.Next(-5, 5), mod.ProjectileType("polarisBolt"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f);

            Dust dust1 = Dust.NewDustDirect(target.Center, 0, 0, 229);
            dust1.noGravity = true;
            dust1.scale = 3f;
            dust1.velocity *= 10f;
			Main.PlaySound(SoundID.Item117, projectile.position);
        }
    }
}