using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles.armorsets
{
    public class barkwoodProj : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("Leaf Guardian");

        }

        public override void SetDefaults()
        {
			projectile.width = 32;
			projectile.height = 32;
			projectile.friendly = true;
			projectile.aiStyle = 0;
            projectile.tileCollide = false;
			projectile.penetrate = -1;
			projectile.timeLeft = 7200;
			projectile.extraUpdates = 1;


        }
		
        bool isShooting;
        float saveShotX;
        float saveShotY;
        float saveShotDistance; //all these to save last targetted noc
        public override void AI()
        {
            Player player = Main.player[projectile.owner];
			CrimsonPlayer modplayer = player.GetModPlayer<CrimsonPlayer>(mod);
			if(!modplayer.barkwoodSet)
			{
				projectile.Kill();
			}

            projectile.position.X = player.Center.X - (float)(player.width / 2);
            projectile.position.Y = player.Center.Y - (float)(player.height / 2) + player.gfxOffY - 60f;;

            if (!player.active)
            {
                projectile.active = false;
                return;
            }


            bool isShooting = false; //at first, this proj will assume that it hasnt shot, when it shoots, it wil send information of the target to shoot block**
            for(int i = 0; i < 200; i++)
            {
                NPC target = Main.npc[i];
                if(Main.npc[i].CanBeChasedBy(this, ignoreDontTakeDamage: true))
                {
                    float shootToX = target.Center.X - projectile.Center.X;
                    float shootToY = target.Center.Y - projectile.Center.Y;
                    float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));

                    shootToX *= 3f / distance;
                    shootToY *= 3f / distance;

                    if(distance < 1000 && Collision.CanHit(projectile.position, projectile.width, projectile.height, Main.npc[i].position, Main.npc[i].width, Main.npc[i].height))
                    {
                        saveShotX = shootToX;
                        saveShotY = shootToY;
                        saveShotDistance = distance;
                        isShooting = true;
                    }   
                }
            } 
            if(isShooting) //** this shoot block
            {
                float shootToX = saveShotX;
                float shootToY = saveShotY;
                float distance = saveShotDistance;

                shotsFire(shootToX, shootToY); 
            }
            count++;
        }
        
        int count = 0;//cooldown
        private void shotsFire(float shootX, float shootY)
        {
            if(count % 100 == 1)
            {
			    Main.PlaySound(SoundID.Item60, projectile.position);
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, shootX, shootY, mod.ProjectileType("barkwoodProjShot"), 10, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
                isShooting = false;
            }
        }
        
        
        public override void Kill(int timeLeft)        
        {
			for (int i = 0; i < 10; i++)
            {
				Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, 128);
				dust.noGravity = true;
				dust.scale = 0.7f;
                dust.velocity *= 4f;
            }                
        }
    }
}