using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tideStrider.Projectiles
{
    public class waterNonBouncingBolt : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("boltOfWaterIGuess");
        }

        public override void SetDefaults()
        {
			projectile.width = 8;
			projectile.height = 8;
            projectile.alpha = 255;
			projectile.friendly = true;
			projectile.ranged = true;
            projectile.aiStyle = 0;
			projectile.penetrate = 3;
			projectile.timeLeft = 480;			
			projectile.tileCollide = true;
        }
        
        public override void AI()
        {
            Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 15);
            dust.noGravity = true;
            dust.scale = 2f;
            dust.velocity *= 0f;
        }

        public override void Kill(int timeLeft)
        {
            for (int i = 0; i < 5; i++)
            {            
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 156);
                dust.velocity *= 3f;
			}
			Main.PlaySound(SoundID.Item10, projectile.position);        
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.AddBuff(103, 800);   
        }
    }
}