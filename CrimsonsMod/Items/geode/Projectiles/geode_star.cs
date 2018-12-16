using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.geode.Projectiles
{
    public class geode_star : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("geode star");

        }

        public override void SetDefaults()
        {
			projectile.CloneDefaults(48);
			aiType = 48;
			projectile.width = 24;
			projectile.height = 24;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.penetrate = 3;
			projectile.timeLeft = 240;
            projectile.alpha = 64;			
			projectile.extraUpdates = 0;
        } 
        public override void AI()
        {
			for (int i = 0; i < 4; i++)
            {
            
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 177);
				dust.noGravity = true;
				dust.scale = 0.6f;
				dust.velocity *= 0f;
            }                

        }
        public override void Kill(int timeLeft)        
        {
			for (int i = 0; i<Main.rand.Next(2, 8); i++)
            {
            
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 177);
				dust.noGravity = true;
				dust.scale = 1.6f;
            }                
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(mod.BuffType("crystal_crush"), 600);
        }
    }
}