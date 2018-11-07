using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class manganese_cloud : ModProjectile  
    { 
	    public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Manganese Cloud");
		}

        public override void SetDefaults()
        {
			projectile.width = 40;
			projectile.height = 100;
			projectile.aiStyle = 45;
		    aiType = 45;
			projectile.friendly = false;
			projectile.hostile = true;
			projectile.tileCollide = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 800;
			projectile.extraUpdates = 1;   
        }
    }
}