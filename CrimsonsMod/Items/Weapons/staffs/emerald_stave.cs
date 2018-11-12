using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.staffs
{
	public class emerald_stave : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Emerald Stave");	
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 42;
			item.magic = true;
			item.mana = 14;
			item.width = 70;
			item.height = 80;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 6;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ProjectileID.EmeraldBolt;
			item.shootSpeed = 15f;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int a = Projectile.NewProjectile(Main.MouseWorld.X, Main.MouseWorld.Y - 250, 0, 10, ProjectileID.EmeraldBolt, damage, knockBack, player.whoAmI);
			Main.projectile[a].tileCollide = false;
			Main.projectile[a].timeLeft = 180;

            int b = Projectile.NewProjectile(Main.MouseWorld.X, Main.MouseWorld.Y + 250, 0, -10, ProjectileID.EmeraldBolt, damage, knockBack, player.whoAmI);
			Main.projectile[b].tileCollide = false;
			Main.projectile[b].timeLeft = 180;

            int c = Projectile.NewProjectile(Main.MouseWorld.X - 250, Main.MouseWorld.Y, 10, 0, ProjectileID.EmeraldBolt, damage, knockBack, player.whoAmI);
			Main.projectile[c].tileCollide = false;
			Main.projectile[c].timeLeft = 180;

            int d = Projectile.NewProjectile(Main.MouseWorld.X + 250, Main.MouseWorld.Y, -10, 0, ProjectileID.EmeraldBolt, damage, knockBack, player.whoAmI);
			Main.projectile[d].tileCollide = false;
			Main.projectile[d].timeLeft = 180;

            
            
            return false;

              
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.EmeraldStaff);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}