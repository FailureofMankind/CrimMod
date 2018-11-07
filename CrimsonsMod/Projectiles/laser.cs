using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class laser : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("laser");

        }

        public override void SetDefaults()
        {
			projectile.width = 22;
			projectile.height = 36;
            projectile.scale = 0.6f;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.aiStyle = 1;
            aiType = ProjectileID.Bullet;
			projectile.penetrate = 1;
            projectile.alpha = 100;			
			projectile.extraUpdates = 1;
            projectile.light = 1f;


        }
		
        
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 20);
        }

        public override void Kill(int timeLeft)        
        {
			for (int i = 0; i<Main.rand.Next(2, 8); i++)
            {
            
				Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 20);
				dust.noGravity = true;
				dust.scale = 1.6f;
            }                
        }
    }
}