using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.geode.Projectiles
{
    public class crystal_armor_proj : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("shiny boi");

        }

        public override void SetDefaults()
        {
			projectile.CloneDefaults(316);
			aiType = 316;
			projectile.magic = false;

			projectile.width = 8;
			projectile.height = 8;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 600;
            projectile.alpha = 255;
            projectile.extraUpdates = 4;

        }
        public override void AI()
		{
            int dusty_boi = Dust.NewDust(projectile.position, projectile.width, projectile.height, 177);
            Main.dust[dusty_boi].noGravity = true;
            Main.dust[dusty_boi].velocity *= 0f;
		}
        public override void Kill(int timeLeft)
        {
            int xplody_boi = Dust.NewDust(projectile.position, projectile.width, projectile.height, 177);
            Main.dust[xplody_boi].noGravity = true;
            Main.dust[xplody_boi].velocity *= 4f;
            Main.dust[xplody_boi].scale *= 1.5f;
            Main.PlaySound(SoundID.NPCHit5, projectile.position);
            
        }
    }	    
}