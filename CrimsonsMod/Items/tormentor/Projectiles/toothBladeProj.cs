using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tormentor.Projectiles
{
	public class toothBladeProj : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 46;
			projectile.height = 44;
            projectile.aiStyle = 3;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 800;
		}
        public override bool OnTileCollide(Vector2 oldVelocity)
		{
            for (int i = 0; i<4; i++)
            {
				int dust = Dust.NewDust(projectile.Center, projectile.width, projectile.height, 14);
				Main.dust[dust].velocity *= 3f;
				Main.dust[dust].scale *= 1.3f;
            }     
			Main.PlaySound(SoundID.Item10, projectile.position);		
        	return false;
		}        
	}
}