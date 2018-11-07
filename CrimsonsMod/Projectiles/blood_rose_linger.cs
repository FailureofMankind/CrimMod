using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
	public class blood_rose_linger : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 120;
			projectile.alpha = 0;
		}

		public override void AI()
		{
				projectile.velocity /= 1.05f;
                
				int dusty_boi = Dust.NewDust(projectile.position, projectile.width, projectile.height, 5);
                Main.dust[dusty_boi].noGravity = true;
                Main.dust[dusty_boi].scale = 3f;
		}

		public override void Kill(int timeLeft)
		{
			Main.PlaySound(SoundID.NPCHit8, projectile.position);
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