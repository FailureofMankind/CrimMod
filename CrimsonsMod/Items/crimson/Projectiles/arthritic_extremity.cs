using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.crimson.Projectiles
{
	public class arthritic_extremity : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.scale = 0.6f;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.aiStyle = 1;
            aiType = ProjectileID.Bullet;
			projectile.penetrate = 2;
			projectile.timeLeft = 800;
		}

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
			for (int i = 0; i<10; i++)
            {
            
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 5);
				dust.noGravity = true;
                dust.velocity *= 8f;
            }                
        
		}

		public override void AI()
		{
			Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 5);
			dust.noGravity = true;
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
			Main.PlaySound(SoundID.Item10, projectile.position);
		}



	}
}