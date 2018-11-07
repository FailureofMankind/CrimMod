using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles.hostile.aerossault
{
    public class aerossault_beam : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("air beam");

        }

        public override void SetDefaults()
        {
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 0;
			projectile.hostile = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 1000;
            projectile.alpha = 255;		
            projectile.extraUpdates = 1;
            projectile.tileCollide = false;
            projectile.netUpdate = true;
            
        }
		
        public override void AI()
        {
            
            for (int i = 0; i<2; i++)
            {            
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 91);
				dust.noGravity = true;
                dust.velocity *= 0f;
            }
        }
    }
}
