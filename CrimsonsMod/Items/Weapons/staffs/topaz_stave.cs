using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.staffs
{
	public class topaz_stave : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Topaz Stave");	
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 34;
			item.magic = true;
			item.mana = 9;
			item.width = 70;
			item.height = 80;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 6;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ProjectileID.TopazBolt;
			item.shootSpeed = 15f;
		}
        
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
           int a = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.TopazBolt, damage, knockBack, player.whoAmI, 0f, 0f);
           Main.projectile[a].penetrate = 3;
            
            
            return false;  
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TopazStaff);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}