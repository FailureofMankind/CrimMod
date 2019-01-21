using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tormentor.Projectiles
{
	public class spitterMagProj : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 26;
			projectile.height = 26;
            projectile.aiStyle = 1;
            aiType = ProjectileID.Bullet;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = 4;
			projectile.timeLeft = 300;
		}
        public override void AI()
        {
            Dust.NewDust(projectile.Center, 0, 0, 75);
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            projectile.velocity *= 0.7f;
        }
	}
}