using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Umbranite.Projectiles
{
    public class rift : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("rift");

        }

        public override void SetDefaults()
        {
			projectile.width = 22;
			projectile.height = 22;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.aiStyle = 1;
            aiType = 182;
			projectile.penetrate = 4;
			projectile.timeLeft = 600;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;
        }
    }
}