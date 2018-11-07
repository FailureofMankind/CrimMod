using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class nightfall : ModItem
	{
        int styleMode = 0;
		
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nightfall");	
			Tooltip.SetDefault("'Dawn will cease to exist...'\nYou can change to 3 different modes\nRight click to cycle through modes");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.magic = true;
			item.mana = 15;
			item.width = 64;
			item.height = 64;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 6;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("nightfall");
			item.shootSpeed = 15f;
		}
        
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
 
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)     //2 is right click
            {
                styleMode++;
                if(styleMode >= 3)
                {
                    styleMode = 0;
                }

			}
            
            return base.CanUseItem(player);
        }	
		
        public override void UpdateInventory(Player player)
        {
            if(styleMode == 0)
            {
			    item.UseSound = SoundID.Item117;
                item.useTime = 14;
                item.useAnimation = 14;
                item.mana = 5;
            }
            if(styleMode == 1)
            {
			    item.UseSound = SoundID.NPCHit56; //oof
                item.useTime = 25;
                item.useAnimation = 25;
                item.mana = 15;

            }
            if(styleMode == 2)
            {
			    item.UseSound = SoundID.Item120; //ice mist
                item.useTime = 30;
                item.useAnimation = 30;
                item.mana = 20;
            }

        }
        
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if(styleMode == 0)
            {
				int numberProjectiles = 2;  //This defines how many projectiles to shot
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
					int b = Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
					Main.projectile[b].timeLeft = 240;
					Main.projectile[b].tileCollide = false;
                }
                return false;
            }
            if(styleMode == 1)
            {
				float numberProjectiles0 = 5; // This defines how many projectiles to shot
				float rotation = MathHelper.ToRadians(30);
				position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f; //this defines the distance of the projectiles form the player when the projectile spawns
				for (int i = 0; i < numberProjectiles0; i++)
				{
					Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles0 - 1))) * (int)(Main.rand.Next(1,3)); // This defines the projectile roatation and speed. .4f == projectile speed
					Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
	
				}
				return false;
            }
            if(styleMode == 2)
            {
                float numberProjectiles2 = 10; // This defines how many projectiles to shot
                float rotation = MathHelper.ToRadians(360);
                position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f; //this defines the distance of the projectiles form the player when the projectile spawns
                for (int i = 0; i < numberProjectiles2; i++)
                    {
                        Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles2 - 1))) * .9f; // This defines the projectile roatation and speed. .4f == projectile speed
                        int a = Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                    }
                return false;
            }
            else
            {
            return false;  
            }
		}
        
        
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "coral_staff");
			recipe.AddIngredient(ItemID.Vilethorn);
			recipe.AddIngredient(ItemID.AmberStaff);
			recipe.AddIngredient(ItemID.AquaScepter);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();

			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(null, "coral_staff");
			recipe1.AddIngredient(ItemID.CrimsonRod);
			recipe1.AddIngredient(ItemID.AmberStaff);
			recipe1.AddIngredient(ItemID.AquaScepter);
			recipe1.AddTile(TileID.DemonAltar);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}