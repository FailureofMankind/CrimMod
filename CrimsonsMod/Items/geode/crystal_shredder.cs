using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.geode
{
	public class crystal_shredder : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystal Shredder");	
			Tooltip.SetDefault("Shred you enemies and foes!\nOccasionally cast a barrage of homing crystals");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 16;
			item.magic = true;
			item.mana = 5;
			item.width = 42;
			item.height = 42;
			item.useTime = 7;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 2;
			item.value = 10;
			item.rare = 6;
			item.UseSound = SoundID.Item13;
			item.autoReuse = true;
			item.shoot = 94;
			item.shootSpeed = 15f;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			int rand = Main.rand.Next(20);
            int numberProjectiles = 4; //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(45)); // This defines the projectiles random spread . 30 degree spread.
				if(rand == 1)
				{
					int a = Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, mod.ProjectileType("crystal_armor_proj"), damage, knockBack, player.whoAmI);
					Main.projectile[a].melee = false;
					Main.projectile[a].magic = true;
				}
				else
				{
					Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
				}
        
			}
            return false;
        }  
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.AddIngredient(ItemID.CrystalStorm);
            recipe.AddIngredient(null, "crystal_geode", 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}