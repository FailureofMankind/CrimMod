using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class AeroSpell : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("jkakbjsbkasjbsksca");

        }

        public override void SetDefaults()
        {
			projectile.width = 40;
			projectile.height = 40;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 400;
            projectile.alpha = 128;		
            projectile.extraUpdates = 1;
            projectile.tileCollide = true;
            
        }
		
        public override void AI()
        {
            projectile.velocity /= 1.04f; 
            projectile.rotation += 0.1f;
            
            for (int i = 0; i<3; i++)
            {            
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 20);
				dust.noGravity = true;
				dust.scale = 0.5f;
            }
        }
    
        public override bool OnTileCollide(Vector2 oldVelocity)
		{
			if (projectile.velocity.X != oldVelocity.X)
			{
				projectile.velocity.X = -oldVelocity.X;
			}
			if (projectile.velocity.Y != oldVelocity.Y)
			{
				projectile.velocity.Y = -oldVelocity.Y;
			}
			
			return false;
		}        

    
    }
}
