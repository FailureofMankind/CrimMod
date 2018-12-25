using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.fungus.Projectiles
{
    public class mushroomSpore : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("mushroom spore");
        }

        public override void SetDefaults()
        {
			projectile.width = 8;
			projectile.height = 8;
            projectile.alpha = 100;
			projectile.friendly = true;
			projectile.magic = true;
            projectile.aiStyle = 0;
			projectile.penetrate = 1;
			projectile.timeLeft = 120;			
			projectile.tileCollide = true;
        }
        
        public override void AI()
        {
            projectile.velocity *= 0.9f;
        }


        public override void Kill(int timeLeft)
        {
            for (int i = 0; i < 9; i++)
            {            
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 45);
                dust.noGravity = true;
                dust.scale = 2f;
                dust.velocity *= 4f;
			}
            for (int i = 0; i < 2; i++)
            {
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-3, 3), Main.rand.Next(-3, 3), mod.ProjectileType("mushroomSporeHom"), projectile.damage, projectile.knockBack, Main.myPlayer);
            }
        }
    }
}