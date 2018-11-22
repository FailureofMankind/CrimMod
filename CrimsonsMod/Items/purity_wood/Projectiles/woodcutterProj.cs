using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.purity_wood.Projectiles
{
	public class woodcutterProj : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 28;
			projectile.height = 28;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.aiStyle = 3;
			projectile.penetrate = -1;
			projectile.timeLeft = 800;
            projectile.netUpdate = true;
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

            for (int i = 0; i<3; i++)
            {
            
				int dust = Dust.NewDust(projectile.Center, projectile.width, projectile.height, 7);
				Main.dust[dust].velocity *= 2f;
				Main.dust[dust].scale *= 1.3f;
            }     
            
			return false;
		}        

	}
}