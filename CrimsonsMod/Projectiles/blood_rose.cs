using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
	public class blood_rose : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 300;
			projectile.alpha = 0;
		}

		public override void AI()
		{
                int c = Dust.NewDust(projectile.position, projectile.width, projectile.height, 5);
                Main.dust[c].scale = 2f;
		}


		public override void Kill(int timeLeft)
		{
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 15, -15, mod.ProjectileType("blood_rose_linger"), projectile.damage, 0, Main.myPlayer); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 15, 15, mod.ProjectileType("blood_rose_linger"), projectile.damage, 0, Main.myPlayer); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, -15, -15, mod.ProjectileType("blood_rose_linger"), projectile.damage, 0, Main.myPlayer); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, -15, 3, mod.ProjectileType("blood_rose_linger"), projectile.damage, 0, Main.myPlayer); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, -20, mod.ProjectileType("blood_rose_linger"), projectile.damage, 0, Main.myPlayer); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 20, mod.ProjectileType("blood_rose_linger"), projectile.damage, 0, Main.myPlayer); //Spawning a projectile

			Main.PlaySound(SoundID.NPCHit8, projectile.position);
		}

	}
}