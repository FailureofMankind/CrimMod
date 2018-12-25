using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.fungus.Projectiles
{
    public class mushroomBolt : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("mushroom bolt");
        }

        public override void SetDefaults()
        {
			projectile.width = 8;
			projectile.height = 8;
			projectile.friendly = true;
			projectile.magic = true;
            projectile.aiStyle = 0;
			projectile.penetrate = 2;
			projectile.timeLeft = 480;			
			projectile.tileCollide = true;
        }
        
        int count = 0;
        public override void AI()
        {
            Dust dust = Dust.NewDustDirect(projectile.Center, 0, 0, 45);
            dust.noGravity = true;
            dust.velocity *= 0f;
        
            if(count >= 60)
            {
                Dust dust1 = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 45);
                dust1.noGravity = true;
                dust1.scale = 1.3f;
                dust1.velocity *= 3f;

                int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, 131, projectile.damage / 2, projectile.knockBack, Main.myPlayer);
                Main.projectile[a].melee = false;
                Main.projectile[a].magic = true;   
                count = 0;             
            }
            count++;
        }
    }
}