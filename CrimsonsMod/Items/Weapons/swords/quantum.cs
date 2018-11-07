using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.swords
{
	public class quantum : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Quantum");
			Tooltip.SetDefault("'simultaneous outcomes...'\nEvery vanilla imbues will have different effects\nSharpened buff will have 'interesting' effect");
		}
		public override void SetDefaults()
		{
			item.damage = 34;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.scale = 1.4f;
			item.useTime = 30;
			item.useAnimation = 30;
            item.useTurn = true;
			item.useStyle = 1;
			item.knockBack = 9;
            item.value = Item.sellPrice(0, 12, 0, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            
			item.shoot = mod.ProjectileType("blank");
			item.shootSpeed = 15f;

		}

		int imbueType = 0;
        public override void UpdateInventory(Player player) //tremor oof
        {
            if (player.HasBuff(71))//venom imbue
            {
				item.shoot = 378;
				item.damage = 100;
				imbueType = 0;
				item.useTime = 13;
				item.useAnimation = 13;
            }
            if (player.HasBuff(73))//cursed inferno imbue
            {
				imbueType = 1;
				item.shoot = 95;
				item.damage = 65;
				item.useTime = 25;
				item.useAnimation = 25;
            }
            if (player.HasBuff(74))//fire imbue
            {
				imbueType = 1;
				item.shoot = 15;
				item.useTime = 18;
				item.useAnimation = 18;
            }
            if (player.HasBuff(75))//gold imbue
            {
				imbueType = 2;
				item.shoot = 242; //high velocity bullet oof
				item.damage = 50;
				item.useTime = 10;
				item.useAnimation = 10;

            }
            if (player.HasBuff(76))//ichor imbue
            {
				imbueType = 1;
				item.shoot = 524;
				item.damage = 40;
				item.useTime = 15;
				item.useAnimation = 15;
            }
            if (player.HasBuff(77))//nanites imbue
            {
				imbueType = 1;
				item.shoot = 440;
				item.useTime = 8;
				item.useAnimation = 8;
				item.damage = 70;
            }
            if (player.HasBuff(78))//confetti imbue
            {
				imbueType = 2;
				item.shoot = 417;
				item.useTime = 45;
				item.useAnimation = 45;
			}
            if (player.HasBuff(79))//poison imbue
            {
				imbueType = 0;
				item.shoot = 523;
				item.useTime = 15;
				item.useAnimation = 15;
            }
            if (player.HasBuff(159))//sharpened imbue
            {
				imbueType = 3;
            }
			if(!player.HasBuff(71) && !player.HasBuff(73) && !player.HasBuff(74) && !player.HasBuff(75) && !player.HasBuff(76) && !player.HasBuff(77) && !player.HasBuff(78) && !player.HasBuff(79) && !player.HasBuff(159))
            {
				imbueType = 0;
				item.damage = 34;
				item.shoot = mod.ProjectileType("blank");
				item.useTime = 30;
				item.useAnimation = 30;
            }       
        }
        
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if(imbueType == 1)
			{
				float numberProjectiles = 5; // This defines how many projectiles to shot
				float rotation = MathHelper.ToRadians(45);
				position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f; //this defines the distance of the projectiles form the player when the projectile spawns
				for (int i = 0; i < numberProjectiles; i++)
				{
					Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .4f; // This defines the projectile roatation and speed. .4f == projectile speed
					int a = Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
					Main.projectile[a].melee = true;
	
				}
				return false;
			}
			if(imbueType == 2)
			{
				int numberProjectiles = 3 + Main.rand.Next(2);  //This defines how many projectiles to shot
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
					Main.projectile[b].melee = true;
					Main.projectile[b].penetrate = 1;
					Main.projectile[b].tileCollide = false;

				}
			
				return false;			
			}
			if(imbueType == 3)
			{
				Projectile.NewProjectile(Main.MouseWorld.X, Main.MouseWorld.Y, 8, 0, type, damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(Main.MouseWorld.X, Main.MouseWorld.Y, -8, 0, type, damage, knockBack, player.whoAmI);

				Projectile.NewProjectile(Main.MouseWorld.X, Main.MouseWorld.Y, 6, 6, type, damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(Main.MouseWorld.X, Main.MouseWorld.Y, -6, -6, type, damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(Main.MouseWorld.X, Main.MouseWorld.Y, -6, 6, type, damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(Main.MouseWorld.X, Main.MouseWorld.Y, 6, -6, type, damage, knockBack, player.whoAmI);
				return false;			
			}

			else
			{
			return true;
			}
			
		}
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GrayMatter");
            recipe.AddIngredient(null, "SkyBlade");
            recipe.AddIngredient(null, "purity_shard");
            recipe.AddIngredient(ItemID.DarkShard);
            recipe.AddIngredient(ItemID.LightShard);
			recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
			
	}
        
        

}


