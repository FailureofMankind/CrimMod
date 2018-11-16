using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class NyanCat : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("NyanCat");

        }

        public override void SetDefaults()
        {
			projectile.width = 12;
			projectile.height = 26;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 10000;
            projectile.tileCollide = true;
			projectile.light = 1f;
			projectile.extraUpdates = 1;        
    

        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.immune[projectile.owner] = 0;
        }
		
    }
}