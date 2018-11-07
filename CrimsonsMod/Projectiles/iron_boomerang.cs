using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class iron_boomerang : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("Iron Boomerang");

        }

        public override void SetDefaults()
        {
			projectile.width = 18;
			projectile.height = 32;
			projectile.aiStyle = 3;
            projectile.scale = 0.7f;
			projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.thrown = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 800;
			projectile.light = 0.5f;
			projectile.extraUpdates = 1;   
    

        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            int rand = Main.rand.Next(3);
            if(rand == 0)
            {
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-10, 10), Main.rand.Next(-10, 10), mod.ProjectileType("iron_boomerang"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-10, 10), Main.rand.Next(-10, 10), mod.ProjectileType("iron_boomerang"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-10, 10), Main.rand.Next(-10, 10), mod.ProjectileType("iron_boomerang"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            }
        }
        
        
    }
}