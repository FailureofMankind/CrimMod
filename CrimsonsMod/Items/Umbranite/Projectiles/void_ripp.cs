using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Umbranite.Projectiles
{
    public class void_ripp : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("void ripp");

        }

        public override void SetDefaults()
        {
			projectile.width = 22;
			projectile.height = 22;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.aiStyle = 1;
            aiType = 1;
			projectile.penetrate = 1;
			projectile.timeLeft = 600;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;
        }
		
		public override bool OnTileCollide(Vector2 oldVelocity)
		{
            projectile.penetrate--;
            int damamge = projectile.damage / 5;

            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, -3, -3, mod.ProjectileType("rift"), damamge, projectile.knockBack, Main.myPlayer, 0f, 0f);
			
			Main.PlaySound(SoundID.Item120, projectile.position);        
            
            for (int i = 0; i<30; i++)
            {            
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 14);   //this adds a vanilla terraria dust to the projectile
				Main.dust[dust].velocity *= 4f;
				Main.dust[dust].scale = 2f;
                Main.dust[dust].noGravity = true;
            }
            
            return false;
		}                
    }
}


