using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.fungus.Projectiles
{
    public class mushroomSporeHom : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("homing mushroom spore");
        }

        public override void SetDefaults()
        {
			projectile.width = 8;
			projectile.height = 8;
			projectile.friendly = true;
			projectile.magic = true;
            projectile.aiStyle = 36;
			projectile.penetrate = 2;
			projectile.timeLeft = 240;			
			projectile.tileCollide = true;
        }
        
        public override void AI()
        {
            Dust dust = Dust.NewDustDirect(projectile.Center, 0, 0, 45);
            dust.noGravity = true;
            dust.scale = 2f;
            dust.velocity *= 0f;
        
            projectile.ai[1] += 1f;
            double degWaveyBoi = (double) projectile.ai[1]; 
            double radWaveyBoi = degWaveyBoi * (Math.PI / 180);

            projectile.position.Y -= (int)(Math.Sin(radWaveyBoi * 25) * 3);
        }
        
        public override bool OnTileCollide(Vector2 oldVelocity)
		{
			if (projectile.velocity.X != oldVelocity.X)
			{
				projectile.velocity.X = -oldVelocity.X;
			}
			if (projectile.velocity.Y != oldVelocity.Y)
			{
				projectile.velocity.Y = -oldVelocity.Y;
			}
            return false;
        }

    }
}