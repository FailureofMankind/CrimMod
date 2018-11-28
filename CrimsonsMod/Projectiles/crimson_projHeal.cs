using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameContent;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Effects;
using Terraria.Localization;
using Terraria.Graphics.Shaders;

namespace CrimsonsMod.Projectiles
{
	public class crimson_projHeal : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("crimson blast");
		}

		public override void SetDefaults()
		{
            projectile.width = 128;
            projectile.height = 128;
            projectile.aiStyle = 1;
            aiType = ProjectileID.Bullet;
            projectile.friendly = true;
            projectile.timeLeft = 10;
            projectile.alpha = 255;			
			projectile.penetrate = -1;
			projectile.tileCollide = true;
            
		}



        public override void AI()
        {
            int dust = Dust.NewDust(projectile.Center, 0, 0, 219);   //this adds a vanilla terraria dust to the projectile
            Main.dust[dust].noGravity = true; 
            Main.dust[dust].scale = 1.2f;
            Main.dust[dust].velocity *= 8f;
        }

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
            Player player = Main.player[projectile.owner];

            target.immune[projectile.owner] = 0;

			player.statLife += 10;

        }
        
	}
}