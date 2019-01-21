using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tormentor.Projectiles
{
	public class bileCyst : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(21);
			aiType = 21;            
			projectile.width = 26;
			projectile.height = 26;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 400;
		}
		public override void Kill(int timeLeft)
		{
			for(int i = 0; i<Main.rand.Next(1, 3); i++)
			{
                int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-5, 5), Main.rand.Next(-5, 5), 480, projectile.damage, 0, Main.myPlayer); //Spawning a projectile                
				Main.projectile[a].ranged = false;
				Main.projectile[a].thrown = true;
			}
			Main.PlaySound(SoundID.Item10, projectile.position);		
		}
	}
}