using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class justice_yellow_back : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("Justice");

        }

        public override void SetDefaults()
        {
			projectile.width = 12;
			projectile.height = 26;
			projectile.aiStyle = 3;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 6000;
            projectile.tileCollide = false;
			projectile.light = 1f;
			projectile.extraUpdates = 1;        
    

        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.immune[projectile.owner] = 4;
        }
		
    }
}