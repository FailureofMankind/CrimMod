using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles.scythe
{
    public class terra_scythe : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("terra scythe");

        }

        public override void SetDefaults()
        {
            projectile.width = 168;     //Set the hitbox width
            projectile.height = 144;       //Set the hitbox height
            projectile.friendly = true;    //Tells the game whether it is friendly to players/friendly npcs or not
            projectile.penetrate = -1;    //Tells the game how many enemies it can hit before being destroyed. -1 = never
            projectile.tileCollide = false; //Tells the game whether or not it can collide with a tile
            projectile.ignoreWater = true; //Tells the game whether or not projectile will be affected by water        
            projectile.melee = true;  //Tells the game whether it is a melee projectile or not

        }
		public override void OnHitNPC(NPC target, int damage, float knockBack, bool crit)
		{
            target.immune[projectile.owner] = 5;

            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, -4, 0, 604, 50, 0, projectile.owner); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 4, 0, 604, 50, 0, projectile.owner); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, -4, 604, 50, 0, projectile.owner); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 4, 604, 50, 0, projectile.owner); //Spawning a projectile

            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 3, -3, 604, 50, 0, projectile.owner); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 3, 3, 604, 50, 0, projectile.owner); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, -3, -3, 604, 50, 0, projectile.owner); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, -3, 3, 604, 50, 0, projectile.owner); //Spawning a projectile
        }


        public override void AI()
        {

            //-------------------------------------------------------------Sound-------------------------------------------------------
            projectile.soundDelay--;
            if (projectile.soundDelay <= 0)//this is the proper sound delay for this type of weapon
            {
                Main.PlaySound(2, (int)projectile.Center.X, (int)projectile.Center.Y, 15);    //this is the sound when the weapon is used
                projectile.soundDelay = 45;    //this is the proper sound delay for this type of weapon
            }
            //-----------------------------------------------How the projectile works---------------------------------------------------------------------
            Player player = Main.player[projectile.owner];
            if (Main.myPlayer == projectile.owner)
            {
                if (!player.channel || player.noItems || player.CCed)
                {
                    projectile.Kill();
                }
            }
            projectile.Center = player.MountedCenter;
            projectile.position.X += player.width / 2 * player.direction;  //this is the projectile width sptrite direction from the playr
            projectile.spriteDirection = player.direction;
            projectile.rotation += 0.3f * player.direction; //this is the projectile rotation/spinning speed
            if (projectile.rotation > MathHelper.TwoPi)
            {
                projectile.rotation -= MathHelper.TwoPi;
            }
            else if (projectile.rotation < 0)
            {
                projectile.rotation += MathHelper.TwoPi;
            }
            player.heldProj = projectile.whoAmI;
            player.itemTime = 2;
            player.itemAnimation = 2;
            player.itemRotation = projectile.rotation;
            
            for(int i = 0; i < 5; i++)
            {
                Dust.NewDust(projectile.position, projectile.width, projectile.height, 74);  //this is the dust that this projectile will spawn
            }


           /* double count = projectile.ai[1];    //i think projectile.ai[1] is another type of tick count passed by the projectile.....?
            double spawn = count % 8;
            
            if(spawn==0)
            {
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-5, 5), Main.rand.Next(-5, 5), mod.ProjectileType("terra_spirit"), 145, 0, Main.myPlayer); //Spawning a projectile
            }

            projectile.ai[1] += 1f;*/
        
        
        }
 
        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)  //this make the projectile sprite rotate perfectaly around the player
        {
            Texture2D texture = Main.projectileTexture[projectile.type];
            spriteBatch.Draw(texture, projectile.Center - Main.screenPosition, null, Color.White, projectile.rotation, new Vector2(texture.Width / 2, texture.Height / 2), 2f, projectile.spriteDirection == 1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally, 0f);
            return false;
        }
    }
}







//thanks to blushiemagic for help!