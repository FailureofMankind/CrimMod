using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.purity_wood.Projectiles
{
	public class barkProj : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 18;
			projectile.height = 18;
			projectile.scale = 1.6f;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.aiStyle = 2;
			projectile.penetrate = 1;
			projectile.timeLeft = 800;
            projectile.netUpdate = true;
		}


        public override void Kill(int timeLeft)
        {
            for (int i = 0; i<5; i++)
            {
            
				int dust = Dust.NewDust(projectile.Center, projectile.width, projectile.height, 7);
				Main.dust[dust].velocity *= 2f;
				Main.dust[dust].scale *= 1.3f;
            }     
            
        }


	}
}