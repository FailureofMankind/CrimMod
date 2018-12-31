using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.nettlevine.Projectiles
{
    public class theJungleBallProj : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("JungleBallProj");
        }

        public override void SetDefaults()
        {
			projectile.width = 32;
			projectile.height = 32;
			projectile.friendly = true;
			projectile.melee = true;
            projectile.aiStyle = 15;
			projectile.penetrate = -1;
			projectile.timeLeft = 3000;			
			projectile.tileCollide = true;
        }
        int counte = 0;
        public override void AI()
        {
            Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, 3);
            dust.noGravity = true;
            dust.scale *= 1.6f;
            dust.velocity *= 5f;
            counte++;
            if(counte >= 5)
            {
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, projectile.velocity.X, projectile.velocity.Y, 228, (int)projectile.damage / 2, projectile.knockBack, Main.myPlayer, 0f, 0f);                
                counte = 0;
            }
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.AddBuff(20, 240);
        }
        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor) //oof
        {
            Texture2D texture = ModLoader.GetTexture("CrimsonsMod/Items/nettlevine/Projectiles/theJungleBallChain");

            Vector2 position = projectile.Center;
            Vector2 mountedCenter = Main.player[projectile.owner].MountedCenter;
            Rectangle? sourceRectangle = new Rectangle?();
            Vector2 origin = new Vector2(texture.Width * 0.5f, texture.Height * 0.5f);
            float num1 = texture.Height;
            Vector2 vector2_4 = mountedCenter - position;
            float rotation = (float)Math.Atan2(vector2_4.Y, vector2_4.X) - 1.57f;
            bool flag = true;
            if (float.IsNaN(position.X) && float.IsNaN(position.Y))
                flag = false;
            if (float.IsNaN(vector2_4.X) && float.IsNaN(vector2_4.Y))
                flag = false;
            while (flag)
            {
                if (vector2_4.Length() < num1 + 1.0)
                {
                    flag = false;
                }
                else
                {
                    Vector2 vector2_1 = vector2_4;
                    vector2_1.Normalize();
                    position += vector2_1 * num1;
                    vector2_4 = mountedCenter - position;
                    Color color2 = Lighting.GetColor((int)position.X / 16, (int)(position.Y / 16.0));
                    color2 = projectile.GetAlpha(color2);
                    Main.spriteBatch.Draw(texture, position - Main.screenPosition, sourceRectangle, color2, rotation, origin, 1f, SpriteEffects.None, 0.0f);
                }
            }

            return true;
        }    
    }
}