using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CrimsonsMod.Projectiles.edgyTormentor
{
    public class horizontalRainBullet : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
		    DisplayName.SetDefault("tormentor bullet");
        }

        public override void SetDefaults()
        {
			projectile.width = 24;
			projectile.height = 32;
			projectile.aiStyle = 0;
            aiType = ProjectileID.Bullet;
			projectile.hostile = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 800;
            projectile.alpha = 100;
            projectile.tileCollide = false;
        }
		int count = 0;
        public override void AI()
        {
            Lighting.AddLight(projectile.position, 0f, 0.5f, 0f);
            count++;
            if(count >= 20)
            {
                count = 0;
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-3,3), -5, mod.ProjectileType("shenaniganTouhouBullet"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-3,3), 5, mod.ProjectileType("shenaniganTouhouBullet"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            }
        }
		
        public override void Kill(int timeLeft)        
        {
			for (int i = 0; i < 10; i++)
            {
				Dust dust = Dust.NewDustDirect(projectile.Center, 0, 0, 75);
                dust.velocity *= 7f;
            }                
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.Green;
        }
    }
}
