using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class hades_bloom : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("bloom");

        }

        public override void SetDefaults()
        {
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.aiStyle = 0;
			projectile.penetrate = -1;
			projectile.timeLeft = 800;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;


        }
		
        public override void AI()
        {
            Dust dust = Dust.NewDustDirect(projectile.position, 0, 0, 173);
            dust.noGravity = true;
            dust.velocity *= 0;
            dust.scale = 1.3f;
        }
        
        
        
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.AddBuff(153, 800);   
        }
    
    
    }
}