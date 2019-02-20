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
    public class tormentorShenaniganBall : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
		    DisplayName.SetDefault("tormentor ball");
        }

        public override void SetDefaults()
        {
			projectile.width = 24;
			projectile.height = 32;
			projectile.aiStyle = 1;
			projectile.hostile = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 120;
            projectile.alpha = 100;		
            projectile.extraUpdates = 1;
            projectile.tileCollide = false;
        }
		
        public override void AI()
        {
            Lighting.AddLight(projectile.position, 0f, 0.5f, 0f);
        }
		
        public override void Kill(int timeLeft)        
        {
			for (int i = 0; i < 10; i++)
            {
				Dust dust = Dust.NewDustDirect(projectile.Center, 0, 0, 75);
                dust.velocity *= 5f;
            }                
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.Green;
        }
    }
}
