using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
    public class god_slayer : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("God Slayer");
			Tooltip.SetDefault("'destroy anyone who stands in your way'");
		}

        public override void SetDefaults()
        {
            item.damage = 145;
            item.noMelee = true;
            item.ranged = true;
            item.width = 30;
            item.height = 42;
            item.useTime = 8;
            item.useAnimation = 8;
            item.useStyle = 5;
            item.shoot = 12;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 0;
            item.value = Item.sellPrice(2, 12, 0, 0);
            item.rare = 11;
            item.UseSound = SoundID.DD2_SkyDragonsFuryShot;
            item.autoReuse = true;
            item.shootSpeed = 25f;

        }

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
            int numberProjectiles = 2 + Main.rand.Next(2);  //This defines how many projectiles to shot
            for (int index = 0; index < numberProjectiles; ++index)
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                vector2_1.Y -= (float)(100 * index);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)Math.Sqrt((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile X position speed and randomnes
                float SpeedY = num17 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile Y position speed and randomnes

                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, 645, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, 711, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, 660, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, 503, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, 439, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));

           
           
           
            }

            return true;
          }

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}          


    }
}