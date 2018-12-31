using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.nettlevine.Projectiles
{
    public class styngxProj : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
		DisplayName.SetDefault("styngxProj");
        }

        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 16;
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = true;
            projectile.melee = true;
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 18f;
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 240f;
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 14f;
        }

        bool isShooting;
        float saveShotX;
        float saveShotY;
        float saveShotDistance; //all these to save last targetted noc
        int count = 0;
        public override void AI()
        {
            Player player = Main.player[projectile.owner];
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

                    shootToX *= 15f / distance;
                    shootToY *= 15f / distance;

                    if(!target.friendly && distance < 240 && Collision.CanHit(projectile.position, projectile.width, projectile.height, Main.npc[i].position, Main.npc[i].width, Main.npc[i].height))
                    {
                        saveShotX = shootToX;
                        saveShotY = shootToY;
                        saveShotDistance = distance;
                        isShooting = true;
                    }   
                }
            } 
            if(isShooting && count > 16) //** this shoot block
            {
                int aP = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, saveShotX, saveShotY, 374, projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
                Main.projectile[aP].minion = false;
                Main.projectile[aP].melee = true;
                isShooting = false;
			    Main.PlaySound(SoundID.Item39, projectile.position);
                count = 0;
            }
            count++;
        }
        
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.AddBuff(20, 60);
        }
        private float Magnitude(Vector2 mag)
        {
            return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);
        }
        
    }
}