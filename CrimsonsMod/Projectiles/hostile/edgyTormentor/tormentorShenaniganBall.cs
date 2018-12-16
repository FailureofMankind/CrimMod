using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles.hostile.edgyTormentor
{
    public class tormentorShenaniganBall : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("tormentor ball");

        }

        public override void SetDefaults()
        {
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 1;
			projectile.hostile = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 120;
            projectile.alpha = 255;		
            projectile.extraUpdates = 1;
            projectile.tileCollide = false;
            
        }
		
        public override void AI()
        {
            
            for (int i = 0; i<5; i++)
            {            
				Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, 75);
				dust.noGravity = true;
                dust.velocity *= 0f;
            }
        }
        public override void Kill(int timeLeft)        
        {
			for (int i = 0; i < 10; i++)
            {
            
				Dust dust = Dust.NewDustDirect(projectile.Center, 0, 0, 75);
                dust.velocity *= 5f;
            }                
        }
    
    }
}
