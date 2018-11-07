using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.crimson.Projectiles
{
	public class flesh_mesh_proj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("wasd");     //The English name of the projectile
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;    //The length of old position to be recorded
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;        //The recording mode
		}
        
        public override void SetDefaults()
		{
			projectile.width = 28;
			projectile.height = 28;
			projectile.scale = 0.6f;
			projectile.friendly = true;
			projectile.thrown = true;
            projectile.aiStyle = 2;
			projectile.penetrate = 6;
			projectile.timeLeft = 800;
			projectile.light = 0.4f;
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
        public override bool OnTileCollide(Vector2 oldVelocity)
		{
			projectile.penetrate--;
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