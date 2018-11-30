using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
    public class true_dagger : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("true dagger");

        }

        public override void SetDefaults()
        {
			projectile.width = 18;
			projectile.height = 28;
			projectile.aiStyle = 1;
            projectile.scale = 0.5f;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 200;
            projectile.alpha = 0;		
            projectile.tileCollide = false;	
            aiType = ProjectileID.Bullet; 			

        }

        public override void AI()
        {
            {         
                for (int i=0; i<5; i++)
                {
                    int a = Dust.NewDust(projectile.position, projectile.width, projectile.height, 20);   //this adds a vanilla terraria dust to the projectile
                    Main.dust[a].noGravity = true;  //this modify the scale of the first dust
                    Main.dust[a].scale = 2f;
                }
            }

        projectile.velocity.Y *= 0.95f;
        projectile.velocity.X *= 1.04f;
        }


        public override void Kill(int timeLeft)    
        {
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, -5, -4, 711, projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, -6, 711, projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 5, -4, 711, projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
        }
    
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
			target.AddBuff(20, 800); //buff id poisoned
			target.AddBuff(24, 800); //buff id onfire
			target.AddBuff(39, 800); //buff id cursed inferno
			target.AddBuff(44, 800); //buff id frostburn
			target.AddBuff(69, 1200); //buff id ichor
			target.AddBuff(31, 300); //buff id confused
			target.AddBuff(31, 70); //buff id venom
			target.AddBuff(31, 153); //buff id shadowflame
		    target.AddBuff(204, 800); //inflicts "oiled" debuff
		    target.AddBuff(67, 800); //inflicts "burning" debuff
		    target.AddBuff(68, 800); //inflicts "suffocation" debuff


        }
        
            
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}