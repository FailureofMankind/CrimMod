using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class Blacklight : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("oof");
        }

        public override void SetDefaults()
        {
			projectile.width = 64;
			projectile.height = 64;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 120;			
			projectile.extraUpdates = 1;
            projectile.light = 1f;
			projectile.tileCollide = false;

        }      
    }
}