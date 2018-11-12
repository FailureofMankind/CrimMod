using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.staffs
{
	public class ruby_stave : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ruby Stave");	
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 64;
			item.magic = true;
			item.mana = 9;
			item.width = 70;
			item.height = 80;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 6;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ProjectileID.RubyBolt;
			item.shootSpeed = 15f;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
				float numberProjectiles0 = 4; // This defines how many projectiles to shot
				float rotation = MathHelper.ToRadians(360);
				position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f; //this defines the distance of the projectiles form the player when the projectile spawns
				for (int i = 0; i < numberProjectiles0; i++)
				{
					Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles0 - 1)) * 0.5f); // This defines the projectile roatation and speed. .4f == projectile speed
					Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
	
				}
				return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RubyStaff);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}