using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles.hostile.seaturtle
{
    public class sea_turtle_trail : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("trail");

        }

        public override void SetDefaults()
        {
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 0;
			projectile.hostile = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 60;
            projectile.alpha = 255;		
            projectile.extraUpdates = 1;
            projectile.tileCollide = false;
            projectile.netUpdate = true;
            
        }
		
        public override void Kill(int timeLeft)
        {
            int a = Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, 513, projectile.damage, 5f, Main.myPlayer);        
            Main.projectile[a].friendly = false;
            Main.projectile[a].hostile = true; 
        }
		
		public override bool OnTileCollide(Vector2 oldVelocity)
		{
            projectile.penetrate--;
            int damamge = projectile.damage / 5;

            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, mod.ProjectileType("manganese_cloud"), damamge, projectile.knockBack, Main.myPlayer, 0f, 0f);
			
			Main.PlaySound(SoundID.Item120, projectile.position);        
            
            for (int i = 0; i<30; i++)
            {            
	            Dust dust;
	            // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
	            Vector2 position = Main.LocalPlayer.Center;
	            dust = Main.dust[Terraria.Dust.NewDust(position, 30, 30, 33, -0.2631581f, 7.105264f, 0, new Color(0,255,217), 1.315789f)];
            	dust.fadeIn = 3f;
            }
            
            return false;
		}   
    }
}
