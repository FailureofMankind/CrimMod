using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Projectiles
{
public class crimson_trident_spear : ModProjectile
{
    public override void SetStaticDefaults()
    {

        DisplayName.SetDefault("spear");

    }
    
    public override void SetDefaults()
    {
    projectile.width = 64;
    projectile.height = 64;
    projectile.aiStyle = 19;
    projectile.friendly  = true;
    projectile.hostile = false;
    projectile.tileCollide = false;
    projectile.penetrate = -1;
    projectile.ownerHitCheck = true;
    projectile.melee = true;
    projectile.timeLeft = 90;
    }

    public float movementFactor
    {
        get { return projectile.ai[0]; }
        set { projectile.ai[0] = value; }
    }

    public override void AI()
		{
            int dust1 = Dust.NewDust(projectile.Center, 0, 0, 219);   //this adds a vanilla terraria dust to the projectile
            Main.dust[dust1].noGravity = true; 
            Main.dust[dust1].scale = 0.7f;
            Main.dust[dust1].velocity.X = projectile.velocity.X * 0.8f;
            Main.dust[dust1].velocity.Y = projectile.velocity.Y * 0.8f;

			// Since we access the owner player instance so much, it's useful to create a helper local variable for this
			// Sadly, Projectile/ModProjectile does not have its own
			Player projOwner = Main.player[projectile.owner];
			// Here we set some of the projectile's owner properties, such as held item and itemtime, along with projectile direction and position based on the player
			Vector2 ownerMountedCenter = projOwner.RotatedRelativePoint(projOwner.MountedCenter, true);
			projectile.direction = projOwner.direction;
			projOwner.heldProj = projectile.whoAmI;
			projOwner.itemTime = projOwner.itemAnimation;
			projectile.position.X = ownerMountedCenter.X - (float)(projectile.width / 2);
			projectile.position.Y = ownerMountedCenter.Y - (float)(projectile.height / 2);
			// As long as the player isn't frozen, the spear can move
			if (!projOwner.frozen)
			{
				if (movementFactor == 0f) // When initially thrown out, the ai0 will be 0f
				{
					movementFactor = -13f; // Make sure the spear moves forward when initially thrown out
					projectile.netUpdate = true; // Make sure to netUpdate this spear
				}
				if (projOwner.itemAnimation < projOwner.itemAnimationMax / 3) // Somewhere along the item animation, make sure the spear moves back
				{
					movementFactor -= 2f;
				}
				else // Otherwise, increase the movement factor
				{
					movementFactor += 2f;
				}
			}
			// Change the spear position based off of the velocity and the movementFactor
			projectile.position += projectile.velocity * movementFactor;
			// When we reach the end of the animation, we can kill the spear projectile
			if (projOwner.itemAnimation == 0)
			{
				projectile.Kill();
			}
			// Apply proper rotation, with an offset of 135 degrees due to the sprite's rotation, notice the usage of MathHelper, use this class!
			// MathHelper.ToRadians(xx degrees here)
			projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(135f);
			// Offset by 90 degrees here
			if (projectile.spriteDirection == -1)
			{
				projectile.rotation -= MathHelper.ToRadians(90f);
			}
        }


		
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.immune[projectile.owner] = 0;
            int dust = Dust.NewDust(target.Center, 0, 0, 219);   //this adds a vanilla terraria dust to the projectile
            Main.dust[dust].noGravity = true; 
            Main.dust[dust].scale = 1.2f;
            Main.dust[dust].velocity *= 8f;
            Projectile.NewProjectile(target.Center.X, target.Center.Y, 0, 0, mod.ProjectileType("crimson_projHeal"), projectile.damage, 0, Main.myPlayer); //Spawning a projectile        

		}
		
}
}