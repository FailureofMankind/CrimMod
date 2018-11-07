using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class lead_boomerang : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("Lead Boomerang");

        }

        public override void SetDefaults()
        {
			projectile.CloneDefaults(182);
			aiType = 182;
			projectile.width = 18;
			projectile.height = 32;
            projectile.scale = 0.7f;
			projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.thrown = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 800;
			projectile.light = 0.5f;
			projectile.extraUpdates = 1;   
    

        }

		public override bool PreKill(int timeLeft)
		{
			projectile.type = 182;
			return true;
		}
        
    }
}