using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.crimson.Projectiles
{
	public class living_gun1 : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.aiStyle = 1;
            projectile.scale = 0.6f;
			aiType = ProjectileID.Bullet;
			projectile.ranged = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 300;
			projectile.alpha = 0;
		}

		public override void AI()
		{
			int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 12);
			Main.dust[dust].noGravity = true;
			Main.dust[dust].velocity *= 0f;
			Main.dust[dust].scale *= 1.3f;
		}


		public override void Kill(int timeLeft)
		{
			for (int i = 0; i<20; i++)
            {
            
				int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 12);
				Main.dust[dust].noGravity = true;
				Main.dust[dust].velocity *= 4f;
				Main.dust[dust].scale *= 1.3f;
            }                

			Main.PlaySound(SoundID.NPCHit8, projectile.position);
		}

        public override bool OnTileCollide(Vector2 oldVelocity)
		{
			projectile.velocity *= 0.7f;
			return false;
		}        
	
	
	}
}