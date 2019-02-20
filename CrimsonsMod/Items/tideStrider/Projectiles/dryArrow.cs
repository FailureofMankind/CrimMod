using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tideStrider.Projectiles
{
    public class dryArrow : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("arrowOfWaterIGuess");
        }

        public override void SetDefaults()
        {
			projectile.width = 8;
			projectile.height = 8;
            projectile.alpha = 128;
			projectile.friendly = true;
			projectile.ranged = true;
            projectile.aiStyle = 1;
			projectile.penetrate = 10;
			projectile.timeLeft = 180;			
			projectile.tileCollide = true;
        }
        
        public override void AI()
        {
            if(Main.rand.Next(2) == 0)
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 15);
                dust.noGravity = true;
                dust.scale = 2f;
                dust.velocity *= 0f;
            }
        }

        bool flagBITCH = true; //if true then bounce
        public override bool OnTileCollide(Vector2 oldVelocity)
		{
            if(flagBITCH)
            {
                projectile.velocity.Y = -5f;
                projectile.velocity.X = 0f;
                flagBITCH = false;
            }
            return false;
        }


        public override void Kill(int timeLeft)
        {
            for (int i = 0; i < 5; i++)
            {            
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 15);
                dust.noGravity = true;
                dust.scale = 2f;
                dust.velocity.X = (float)Main.rand.Next(-5, 5);
                dust.velocity.Y = (float)Main.rand.Next(-5, 5);
			}
			Main.PlaySound(SoundID.Item10, projectile.position);        
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.AddBuff(103, 800);   
        }
    }
}