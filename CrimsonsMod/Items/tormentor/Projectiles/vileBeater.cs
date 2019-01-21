using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tormentor.Projectiles
{
	public class vileBeater : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 26;
			projectile.height = 26;
            projectile.aiStyle = 1;
            aiType = ProjectileID.Bullet;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 400;
		}
        public override void AI()
        {
            Dust.NewDust(projectile.Center, 0, 0, 75);
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if(Main.rand.Next(5) == 1)
            target.AddBuff(39, 300); //cursed inferno
        }
	}
}