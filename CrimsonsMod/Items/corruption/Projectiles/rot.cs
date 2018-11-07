using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.corruption.Projectiles
{
	public class rot : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.tileCollide = false;
			projectile.magic = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 10;
			projectile.light = 0.5f;
			projectile.alpha = 255;
		}

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
			for (int i = 0; i<Main.rand.Next(30); i++)
            {
            
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 14);
				dust.noGravity = true;
                dust.velocity *= 8f;
            }                
        }


	}
}