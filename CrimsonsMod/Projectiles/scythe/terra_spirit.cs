using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace CrimsonsMod.Projectiles.scythe
{
    public class terra_spirit : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("wrath");

        }

        public override void SetDefaults()
        {
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = -1;
            projectile.melee = true;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 880;
			projectile.light = 0.5f;
            projectile.tileCollide = false;
            projectile.alpha = 90;			
			projectile.extraUpdates = 1;
        }

        public override void AI()
        {
            Lighting.AddLight(projectile.Center, 0.9f, 0.4f, 0.4f);
            

            //Making player variable "p" set as the projectile's owner
            Player p = Main.player[projectile.owner];

            //Factors for calculations
            double deg = (double) projectile.ai[1]; //The degrees, you can multiply projectile.ai[1] to make it orbit faster, may be choppy depending on the value
            double rad = deg * (Math.PI / 180); //Convert degrees to radians
            double dist = 10 + (double)(projectile.ai[1] / 5) ; //Distance away from the player
        
            /*Position the player based on where the player is, the Sin/Cos of the angle times the /
            /distance for the desired distance away from the player minus the projectile's width   /
            /and height divided by two so the center of the projectile is at the right place.     */
            projectile.position.X = p.Center.X - (int)(Math.Cos(rad) * dist) - projectile.width/2;
            projectile.position.Y = p.Center.Y - (int)(Math.Sin(rad) * dist) - projectile.height/2;
        
            projectile.ai[1] += 2f;
         
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 75);   //this adds a vanilla terraria dust to the projectile
                Main.dust[dust].velocity *= 3f;  //this modify the velocity of the first dust
                Main.dust[dust].scale = 0.8f;  //this modify the scale of the first dust

        }

        public override void Kill(int timeLeft)
        {
            for(int i = 0; i < 25; i++)
                {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 75);   //this adds a vanilla terraria dust to the projectile
                Main.dust[dust].velocity /= 5f;  //this modify the velocity of the first dust
                Main.dust[dust].scale = 1.3f;  //this modify the scale of the first dust
                }
			Main.PlaySound(SoundID.NPCHit54, projectile.position);        
        }

    }
}